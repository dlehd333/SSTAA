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
    public partial class TitleForm : XtraForm
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void TitleForm_Click(object sender, EventArgs e)
        {
            OnClickTitleForm();
        }

        #region ClickTitleForm event things for C# 3.0
        public event EventHandler<ClickTitleFormEventArgs> ClickTitleForm;

        protected virtual void OnClickTitleForm(ClickTitleFormEventArgs e)
        {
            if (ClickTitleForm != null)
                ClickTitleForm(this, e);
        }

        private ClickTitleFormEventArgs OnClickTitleForm()
        {
            ClickTitleFormEventArgs args = new ClickTitleFormEventArgs();
            OnClickTitleForm(args);

            return args;
        }

        public class ClickTitleFormEventArgs : EventArgs { }
        #endregion
    }
}
