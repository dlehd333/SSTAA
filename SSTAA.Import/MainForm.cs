using SSTAA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSTAA.Import
{
    public partial class MainForm : Form
    {
        private int _timeTableCount;
        private int _landPriceIndexMonthCount;
        List<List<string>> rows = new List<List<string>>();
        private int _checkRadioButton;

        private ManualResetEvent _pause = new ManualResetEvent(false);

        public MainForm()
        {
            InitializeComponent();

            _timeTableCount = 20;
            _landPriceIndexMonthCount = 70;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            _checkRadioButton = 0;

            bgwFileLoad.WorkerSupportsCancellation = true;
            bgwServerSave.WorkerSupportsCancellation = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _pause.Reset();

            // 작업중인 내용(백그라운드워커)을 일시 중지시키고 종료할 것인지 묻는다
            if(bgwFileLoad.IsBusy || bgwServerSave.IsBusy)
            {
                Utility.Mbox("경고", "작업이 진행중입니다.\n종료하시려면 작업을 완료하시거나 중지해 주세요");
                e.Cancel = true;
            }

            _pause.Set();

            base.OnClosing(e);
        }

        private bool CheckRadioButtonChecked()
        {
            if(_checkRadioButton == 0)
            {
                Utility.Mbox("오류", "저장할 테이블을 선택해라");
                return false;
            }
            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            if(bgwFileLoad.IsBusy || bgwServerSave.IsBusy)
                return;

            _pause.Set();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                bgwFileLoad.RunWorkerAsync(openFileDialog1.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            if (bgwFileLoad.IsBusy || bgwServerSave.IsBusy)
                return;

            if(rows.Count == 0 || dataGridView1.Rows.Count == 0)
                return;

            _pause.Set();

            bgwServerSave.RunWorkerAsync(_checkRadioButton);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;
            _checkRadioButton = int.Parse(checkedRadioButton.Tag.ToString());

            rows.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            List<string> columns = GetColumns(_checkRadioButton);

            if (columns == null)
                return;

            foreach (string column in columns)
            {
                dataGridView1.ColumnCount += 1;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = column;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = column;
            }
        }

        private void ReadCSV(string fileName)
        {
            using (StreamReader csv = new StreamReader(fileName, Encoding.UTF8, false))
            {
                if(!csv.EndOfStream)
                    csv.ReadLine();

                while (!csv.EndOfStream)
                {
                    string array = csv.ReadLine();
                    if (string.IsNullOrEmpty(array)) return;

                    array.Replace("\"", "");
                    string[] values = array.Split(',');
                    rows.Add(new List<string>(values.ToList()));
                }
            }
        }

        private void bgwFileLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadCSV((string)e.Argument);
        }

        private void bgwFileLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _pause.Reset();

            dataGridView1.Rows.Clear();

            foreach (List<string> row in rows.GetRange(1, (rows.Count > 100 ? 100 : rows.Count - 1)))
            {
                dataGridView1.Rows.Add(row.GetRange(0, (dataGridView1.ColumnCount >= row.Count ? row.Count : dataGridView1.ColumnCount)).ToArray());
            }
        }

        private void bgwServerSave_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((int)e.Argument == 1)
                return;
            else if ((int)e.Argument == 2)
                SaveStation();
            else if ((int)e.Argument == 3)
                SaveFootTraffic();
            else if ((int)e.Argument == 4)
                SaveLandPriceIndex();
            else if ((int)e.Argument == 5)
                SaveCompetitor();
        }

        private void SaveStation()
        {
            // 역번호, 역이름, 주소(구), 주소(동)
            List<Location> locations = Dao.Location.GetAll();
            List<Station> stations = new List<Station>();
            int beforeLocationCount = locations.Count;

            for (int i =0; i < rows.Count; ++i)
            {
                Location location = CheckLocation(locations, rows[i][2], rows[i][3]);

                Station station = new Station() { Location = location };
                station.StationId = int.Parse(rows[i][0]);
                station.Name = rows[i][1];
                stations.Add(station);
            }

            using (var context = DbContextCreator.Create())
            {
                for (int i = beforeLocationCount; i < locations.Count; ++i)
                    context.Locations.Add(locations[i]);
                context.Stations.AddRange(stations);
                context.SaveChanges();
            }
        }

        private Location CheckLocation(List<Location> locations, string first, string second)
        {
            int maxFirstId = locations.Count != 0 ? (locations.Max(x => x.LocationId) / 100) + 1 : 1;

            Location firstLocation = new Location();
            if (locations.Find(x => x.Name == first) == null)
            {
                firstLocation.Name = first;
                firstLocation.LocationId = maxFirstId * 100;
                locations.Add(firstLocation);
            }

            int upperId = locations.Find(x => x.Name == first).LocationId;

            Location secondLocation = new Location();
            if (locations.Find(x => x.Name == second) == null ||
                (locations.Find(x => x.Name == second) != null && locations.Find(x => x.Name == second).UpperId != upperId))
            {
                secondLocation.Name = second;
                secondLocation.UpperId = upperId;
                secondLocation.LocationId = locations.Find(x => x.UpperId == upperId) == null ?
                    upperId + 1 : locations.Where(x => x.UpperId == upperId).Max(x => x.LocationId) + 1;
                secondLocation.Location2 = locations.Find(x => x.LocationId == secondLocation.UpperId);
                locations.Add(secondLocation);
            }
            else
                secondLocation = locations.Find(x => x.Name == second && x.UpperId == upperId);

            return secondLocation;
        }

        private void SaveFootTraffic()
        {
            List<FootTraffic> footTraffics = new List<FootTraffic>();
            List<Station> stations = Dao.Station.GetAll();

            // "날짜(일)", "평일,주말", "역번호", "승차,하차", "06시이전", "06~07", "07~08", "08~09",
            // "09~10", "10~11", "11~12", "12~13", "13~14", "14~15", "15~16", "16~17", "18~19", "19~20",
            // "20~21", "21~22", "22~23", "23~24", "24시이후"
            // Date, IsWeekend(true-주말), StationId, IsOnBoard(true-승차), TimetableId, Count
            for (int i =0; i < rows.Count; i++)
            {
                Station station = stations.Find(x => x.Name == rows[i][2]);

                if (station == null)
                    continue;

                for(int j = 0; j < _timeTableCount; ++j)
                {
                    FootTraffic footTraffic = new FootTraffic();
                    footTraffic.Date = DateTime.Parse(rows[i][0]);
                    footTraffic.IsWeekend = rows[i][1] == "주말" ? true : false;
                    footTraffic.StationId = station.StationId;
                    footTraffic.IsOnBoard = rows[i][3] == "승차" ? true : false;
                    footTraffic.TimetableId = i + 1;
                    footTraffic.Count = int.Parse(rows[i][j + 4]);
                    footTraffics.Add(footTraffic);
                }
            }

            using (var context = DbContextCreator.Create())
            {
                context.FootTraffics.AddRange(footTraffics);
                context.SaveChanges();
            }
        }

        private void SaveLandPriceIndex()
        {
            // "주소(구)", "14/11", "14/12",
            // "15/1", "15/2", "15/3", "15/4", "15/5", "15/6", "15/7", "15/8", "15/9", "15/10", "15/11", "15/12",
            // "16/1", "16/2", "16/3", "16/4", "16/5", "16/6", "16/7", "16/8", "16/9", "16/10", "16/11", "16/12",
            // "17/1", "17/2", "17/3", "17/4", "17/5", "17/6", "17/7", "17/8", "17/9", "17/10", "17/11", "17/12",
            // "18/1", "18/2", "18/3", "18/4", "18/5", "18/6", "18/7", "18/8", "18/9", "18/10", "18/11", "18/12",
            // "19/1", "19/2", "19/3", "19/4", "19/5", "19/6", "19/7", "19/8", "19/9", "19/10", "19/11", "19/12",
            // "20/1", "20/2", "20/3", "20/4", "20/5", "20/6", "20/7", "20/8"
            // Month, LocationId, Index

            List<LandPriceIndex> landPriceIndices = new List<LandPriceIndex>();
            List<Location> locations = Dao.Location.GetAll();

            for(int i =0; i < rows.Count; ++i)
            {
                string locationName = rows[i][0].Replace("서울 ", "");

                Location location = locations.Find(x => x.Name == locationName);

                if (location == null)
                    continue;

                DateTime month = new DateTime(2014, 11, 1);

                for (int j = 0; j < _landPriceIndexMonthCount; ++j)
                {
                    LandPriceIndex landPriceIndex = new LandPriceIndex();
                    landPriceIndex.Month = new DateTime(month.Year + (j + 10) / 12, (month.Month + j) % 12 == 0 ? 12 : (month.Month + j) % 12, 1);
                    landPriceIndex.LocationId = location.LocationId;
                    landPriceIndex.Index = decimal.Parse(rows[i][j + 1]);
                    landPriceIndices.Add(landPriceIndex);
                }
            }

            using (var context = DbContextCreator.Create())
            {
                context.LandPriceIndexes.AddRange(landPriceIndices);
                context.SaveChanges();
            }
        }

        private void SaveCompetitor()
        {
            List<Competitor> competitors = new List<Competitor>();
            List<Location> locations = Dao.Location.GetAll();
            List<Field> fields = Dao.Field.GetAll();

            int beforeLocationCount = locations.Count;
            int beforeFieldCount = fields.Count;

            for (int i = 0; i < rows.Count; ++i)
            {
                Location location = CheckLocation(locations, rows[i][0], rows[i][1]);
                Field field = CheckField(fields, rows[i][2]);

                Competitor competitor = new Competitor() { Location = location, Field = field };
                competitor.Count = int.Parse(rows[i][3]);
                competitors.Add(competitor);
            }

            using (var context = DbContextCreator.Create())
            {
                for (int i = beforeLocationCount; i < locations.Count; ++i)
                    context.Locations.Add(locations[i]);
                for (int i = beforeFieldCount; i < fields.Count; ++i)
                    context.Fields.Add(fields[i]);
                context.Competitors.AddRange(competitors);
                context.SaveChanges();
            }
        }

        private Field CheckField(List<Field> fields, string name)
        {
            Field field = new Field();
            if (fields.Find(x => x.Name == name) == null)
            {
                field.Name = name;
                fields.Add(field);
            }
            else
                field = fields.Find(x => x.Name == name);

            return field;
        }

        private void bgwServerSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _pause.Reset();

            Utility.Mbox("알림", "완료");
        }

        private List<string> GetColumns(int num)
        {
            switch (num)
            {
                case 1:
                    return new List<string>() { "주소(구)", "주소(동)" };
                case 2:
                    return new List<string>() { "역번호", "역이름", "주소(구)", "주소(동)" };
                case 3:
                    return new List<string>() { "날짜(일)", "평일주말", "역번호", "승하차", "06시이전", "06~07", "07~08", "08~09",
                "09~10", "10~11", "11~12", "12~13", "13~14", "14~15", "15~16", "16~17", "18~19", "19~20",
                "20~21", "21~22", "22~23", "23~24", "24시이후"};
                case 4:
                    return new List<string>() { "주소(구)", "14/11", "14/12",
                "15/1", "15/2", "15/3", "15/4", "15/5", "15/6", "15/7", "15/8", "15/9", "15/10", "15/11", "15/12",
                "16/1", "16/2", "16/3", "16/4", "16/5", "16/6", "16/7", "16/8", "16/9", "16/10", "16/11", "16/12",
                "17/1", "17/2", "17/3", "17/4", "17/5", "17/6", "17/7", "17/8", "17/9", "17/10", "17/11", "17/12",
                "18/1", "18/2", "18/3", "18/4", "18/5", "18/6", "18/7", "18/8", "18/9", "18/10", "18/11", "18/12",
                "19/1", "19/2", "19/3", "19/4", "19/5", "19/6", "19/7", "19/8", "19/9", "19/10", "19/11", "19/12",
                "20/1", "20/2", "20/3", "20/4", "20/5", "20/6", "20/7", "20/8"};
                case 5:
                    return new List<string>() { "주소(구)", "주소(동)", "영역", "값"};
                default:
                    return null;
            }
        }
    }
}
