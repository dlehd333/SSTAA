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
    public partial class AnnualScoreForm : XtraForm
    {
        public AnnualScoreForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FomulaInformationForm fomulaInformationForm = new FomulaInformationForm();
            fomulaInformationForm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region GoBack event things for C# 3.0
        public event EventHandler<GoBackEventArgs> GoBack;

        protected virtual void OnGoBack(GoBackEventArgs e)
        {
            if (GoBack != null)
                GoBack(this, e);
        }

        private GoBackEventArgs OnGoBack()
        {
            GoBackEventArgs args = new GoBackEventArgs();
            OnGoBack(args);

            return args;
        }

        /*private GoBackEventArgs OnGoBackForOut()
        {
            GoBackEventArgs args = new GoBackEventArgs();
            OnGoBack(args);

            return args;
        }*/

        public class GoBackEventArgs : EventArgs
        {


            /*public GoBackEventArgs()
            {
            }

            public GoBackEventArgs()
            {

            }*/
        }
        #endregion
    }
}
