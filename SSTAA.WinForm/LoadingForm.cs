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
    public partial class LoadingForm : XtraForm
    {
        public DateTime LoadingTime { get; set; }

        public LoadingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            LoadingTime = DateTime.Now;
        }

        protected override void OnClosed(EventArgs e)
        {
            Utility.Mbox("안내", $"경과시간 : {DateTime.Now - LoadingTime}");

            base.OnClosed(e);
        }
    }
}
