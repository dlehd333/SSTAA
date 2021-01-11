using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSTAA.Data;
using DevExpress.XtraMap;
using System.IO;
using System.Threading;

namespace SSTAA.WinForm
{
    public partial class SelectTownForm : XtraForm
    {
        private List<string> _path = new List<string>();
        public int districtNumber { get; set; } = -1;
        public List<Location> locations { get; set; } = Dao.Location.GetByGu();
        public SelectTownForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            _path.Add(Path.Combine(Directory.GetCurrentDirectory(), "TL_SCCO_SIG_W.shp"));
            _path.Add(Path.Combine(Directory.GetCurrentDirectory(), "TL_SCCO_SIG_W.dbf"));
            _path.Add(Path.Combine(Directory.GetCurrentDirectory(), "TL_SCCO_SIG_W.prj"));
            _path.Add(Path.Combine(Directory.GetCurrentDirectory(), "TL_SCCO_SIG_W.shx"));

            using(FileStream fs = new FileStream(_path[0], FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Properties.Resources.TL_SCCO_SIG_W);
                bw.Close();
            }
            using (FileStream fs = new FileStream(_path[1], FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Properties.Resources.TL_SCCO_SIG_W1);
                bw.Close();
            }
            using (FileStream fs = new FileStream(_path[2], FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Properties.Resources.TL_SCCO_SIG_W2);
                bw.Close();
            }
            using (FileStream fs = new FileStream(_path[3], FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Properties.Resources.TL_SCCO_SIG_W3);
                bw.Close();
            }

            //File.WriteAllBytes(_path[0], Properties.Resources.TL_SCCO_SIG_W);
            //File.WriteAllBytes(_path[1], Properties.Resources.TL_SCCO_SIG_W1);
            //File.WriteAllBytes(_path[2], Properties.Resources.TL_SCCO_SIG_W2);
            //File.WriteAllBytes(_path[3], Properties.Resources.TL_SCCO_SIG_W3);

            shapefileDataAdapter1.DefaultEncoding = Encoding.GetEncoding(51949);
            shapefileDataAdapter1.FileUri = new Uri(_path[0], UriKind.Absolute);

            mapControl1.CenterPoint = new GeoPoint(37.5656754986042d, 126.98202985079d);
            mapControl1.ZoomLevel = 10.8d;

            vectorItemsLayer1.ItemStyle.Fill = Color.FromArgb(90, Color.White);
            vectorItemsLayer1.ItemStyle.Stroke = Color.White;
            vectorItemsLayer1.SelectedItemStyle.Fill = Color.FromArgb(120, Color.Blue);

            cbxField.Properties.Items.AddRange(Dao.Field.GetFieldName());

            ResumeGu();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            foreach (var path in _path)
                FileDelete(path);

            Application.ExitThread();
            Environment.Exit(0);
        }

        public static bool FileDelete(string path)
        {
            FileInfo file = new FileInfo(path);
            try
            {
                if (file.Exists)
                {
                    file.Delete();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ResumeGu()
        {
            if (districtNumber == -1)
            {
                lblDisplayStation.Text = "해당구 역 현황\n";
                return;
            }

            List<string> stations = Dao.Station.GetStationNameByGu(districtNumber);
            lblDisplayStation.Text = $"{locations.Find(x => x.LocationId == districtNumber).Name} 역 현황\n" + Environment.NewLine;
            
            stations.Sort();
            stations = stations.Distinct().ToList();

            foreach (string x in stations)
            {
                lblDisplayStation.Text += x + Environment.NewLine;
            }
        }

        #region ClickResultButton event things for C# 3.0
        public event EventHandler<ClickResultButtonEventArgs> ClickResultButton;

        protected virtual void OnClickResultButton(ClickResultButtonEventArgs e)
        {
            if (ClickResultButton != null)
                ClickResultButton(this, e);
        }

        private ClickResultButtonEventArgs OnClickResultButton(int upperLocationId, int fieldId)
        {
            ClickResultButtonEventArgs args = new ClickResultButtonEventArgs(upperLocationId, fieldId);
            OnClickResultButton(args);

            return args;
        }

        public class ClickResultButtonEventArgs : EventArgs
        {
            public ClickResultButtonEventArgs() { }
            public ClickResultButtonEventArgs(int upperLocationId, int fieldId)
            {
                UpperLocationId = upperLocationId;
                FieldId = fieldId;
            }
            public int UpperLocationId { get; set; }
            public int FieldId { get; set; }
        }
        #endregion

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (cbxField.SelectedIndex == -1 || districtNumber == -1)
            {
                Utility.Mbox("오류", "항목을 선택해 주세요");
                return;
            }

            OnClickResultButton(districtNumber, cbxField.SelectedIndex + 1);
        }

        private void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            districtNumber = locations.Find(x => x.Name == (string)e.Item.Attributes[1].Value).LocationId;
            ResumeGu();
        }

        private void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e)
        {
            if (e.Selection.Count == 0)
                districtNumber = -1;
            ResumeGu();
        }
    }
}
