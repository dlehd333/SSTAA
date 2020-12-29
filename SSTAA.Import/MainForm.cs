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
        List<List<string>> rows = new List<List<string>>();
        private int _checkRadioButton;

        private ManualResetEvent _pause = new ManualResetEvent(false);

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            _checkRadioButton = 1;

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
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            if(bgwFileLoad.IsBusy || bgwServerSave.IsBusy)
            {
                return;
            }

            _pause.Set();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                bgwFileLoad.RunWorkerAsync(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            if (bgwFileLoad.IsBusy || bgwServerSave.IsBusy)
            {
                return;
            }

            if(rows.Count == 0 || dataGridView1.Rows.Count == 0)
            {
                return;
            }

            _pause.Set();

            bgwServerSave.RunWorkerAsync(_checkRadioButton);
        }

        private void ReadCSV(string fileName)
        {
            using (StreamReader csv = new StreamReader(fileName, Encoding.UTF8, false))
            {
                while (!csv.EndOfStream)
                {
                    string array = csv.ReadLine();
                    if (string.IsNullOrEmpty(array)) return;

                    string[] values = array.Split(',');
                    rows.Add(new List<string>(values.ToList()));
                }
            }
        }

        private void bgwFileLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadCSV((string)e.Argument);
        }

        private void bgwFileLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwFileLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.Rows.Clear();

            // ---------------------------------
            dataGridView1.Columns.Clear();
            for(int i =0; i < rows[0].Count; i++)
            {
                dataGridView1.ColumnCount++;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = rows[0][i];
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = rows[0][i];
            }
            // ---------------------------------

            foreach (List<string> row in rows.GetRange(1, (rows.Count > 100 ? 100 : rows.Count - 1)))
            {
                dataGridView1.Rows.Add(row.GetRange(0, (dataGridView1.ColumnCount >= row.Count ? row.Count : dataGridView1.ColumnCount)).ToArray());
            }
        }

        private void bgwServerSave_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwServerSave_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwServerSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
