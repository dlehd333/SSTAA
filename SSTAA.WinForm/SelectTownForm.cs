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
            cbxGu.Properties.Items.AddRange(Dao.Location.GetGuName());

            cbxGu.SelectedIndexChanged += cbxGu_SelectedIndexChanged;
        }

        private void ResumeGu()
        {
            List<string> stations = Dao.Station.GetStationNameByGu((cbxGu.SelectedIndex + 1) * 100);
            lblDisplayStation.Text = "해당구 역 현황\n" + Environment.NewLine;
            
            stations.Sort();
            stations = stations.Distinct().ToList();
            stations.RemoveAt(0);

            foreach (string x in stations)
            {
                lblDisplayStation.Text += x + Environment.NewLine;
            }

            //AnnualScoreForm(SelectedGu) 오픈

            OnClickResultButton();
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.Mbox("알림", $"바뀐 번호는 {cbxField.SelectedIndex + 1}이다");
        }
        private void cbxGu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.Mbox("알림", $"바뀐 번호는 {(cbxGu.SelectedIndex + 1) * 100}이다");
            ResumeGu();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            //cbx.Text 읽음(string SelectedGu)
            
            //Now Loading

            //AnnualScoreForm(SelectedGu) 오픈
        }

        #region ClickResultButton event things for C# 3.0
        public event EventHandler<ClickResultButtonEventArgs> ClickResultButton;

        protected virtual void OnClickResultButton(ClickResultButtonEventArgs e)
        {
            if (ClickResultButton != null)
                ClickResultButton(this, e);
        }

        private ClickResultButtonEventArgs OnClickResultButton()
        {
            ClickResultButtonEventArgs args = new ClickResultButtonEventArgs();
            OnClickResultButton(args);

            return args;
        }

        public class ClickResultButtonEventArgs : EventArgs
        {
        }
        #endregion
    }
}
