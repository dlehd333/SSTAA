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

namespace SSTAA.WinForm
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            TitleForm titleForm = new TitleForm();
            titleForm.ClickTitleForm += TitleForm_ClickTitleForm;
            ShowChildForm(titleForm);
        }

        private void TitleForm_ClickTitleForm(object sender, TitleForm.ClickTitleFormEventArgs e)
        {
            SelectTownForm selectTownForm = new SelectTownForm();
            // 이벤트 추가
            ShowChildForm(selectTownForm);

            //StationScoreForm stationScoreForm = new StationScoreForm();
            //// 이벤트 추가
            //ShowChildForm(stationScoreForm);

            //AnnualScoreForm annualScoreForm = new AnnualScoreForm();
            //// 이벤트 추가
            //ShowChildForm(annualScoreForm);
        }

        private void ShowChildForm(Form form)
        {
            if (form == null)
                return;

            var childForm = MdiChildren.FirstOrDefault(x => x.GetType() == form.GetType());

            if (childForm != null)
            {
                childForm.Close();
            }

            ShowForm(form);
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }

    public class XtraTabbedMdiManagerExtend : DevExpress.XtraTabbedMdi.XtraTabbedMdiManager, DevExpress.XtraTab.IXtraTabProperties
    {
        public XtraTabbedMdiManagerExtend(IContainer container) : base(container) { }
        DevExpress.Utils.DefaultBoolean DevExpress.XtraTab.IXtraTabProperties.ShowTabHeader { get { return DevExpress.Utils.DefaultBoolean.False; } }
    }
}
