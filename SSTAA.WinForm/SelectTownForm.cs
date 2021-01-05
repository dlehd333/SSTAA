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

namespace SSTAA.WinForm
{
    public partial class SelectTownForm : XtraForm
    {
        public SelectTownForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            cbxField.Properties.Items.AddRange(Dao.Field.GetFieldName());
            cbxGu.Properties.Items.AddRange(Dao.Location.GetGu());

            ////cbxGu 이벤트 선언
            //cbxGu.SelectComboBox += cbxGu_SelectComboBox;
            //List<string> stations = Dao.Location.GetByGu();
            //stations.Sort();
            //stations.RemoveAt(0);
            //cbxGu.Initialize(stations); // ??????
            //lblDisplayStation.Text = stations
        }

        //private void cbxGu_SelectComboBox(object sender, cbxGu.SelectComboBoxEventArgs e)
        //{
        //    SelectedGu = e.Item;
        //    갱신
        //}

        private void btnResult_Click(object sender, EventArgs e)
        {
            //cbx.Text 읽음(string SelectedGu)

            //AnnualScoreForm(SelectedGu) 오픈
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.Mbox("알림", $"바뀐 번호는{cbxField.SelectedIndex + 1}이다");
        }

        private void cbxGu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.Mbox("알림", $"바뀐 번호는{(cbxGu.SelectedIndex + 1) * 100}이다");
        }
    }
}
