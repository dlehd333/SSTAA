using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

        private void grdScore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            GridView view = (GridView)grdScore.GetViewAt(e.Location);
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

            //if (hitInfo.InRow && hitInfo.RowHandle >= 0)
            if (!hitInfo.InRow || hitInfo.RowHandle < 0)
                return;

            //Model score = view.GetFocusedRow() as Model;

            //if (score == null)
            //    return;

            //StationScoreForm form = new StationScoreForm(score.stationId);
            //form.ShowDialog();
        }
    }
}
