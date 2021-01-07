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
using SSTAA.Data;

namespace SSTAA.WinForm
{
    public partial class AnnualScoreForm : XtraForm
    {
        public int UpperLocationId { get; set; }
        public int FieldId { get; set; }
        public LoadingForm LoadingForm { get; set; } = new LoadingForm();
        public AnnualScoreForm()
        {
            InitializeComponent();
        }

        public AnnualScoreForm(int upperLocationId, int fieldId) : this()
        {
            UpperLocationId = upperLocationId;
            FieldId = fieldId;
            lblViewCategory.Text = "지역구 : " + Dao.Location.GetName(upperLocationId) + Environment.NewLine +
                "업종 : " + Dao.Field.GetName(fieldId);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bgwDataSource.RunWorkerAsync();
            LoadingForm.ShowDialog();
            WriteRecommendLable();
        }

        private void WriteRecommendLable()
        {
            lblViewRank.Text = "";
            List<AnnualEvaluationScoreModel> models = annualEvaluationScoreModelBindingSource.DataSource as List<AnnualEvaluationScoreModel>;
            for(int i =0;i < (models.Count >= 5 ? 5 : models.Count); i++)
                lblViewRank.Text += $"{i + 1}위" + Environment.NewLine + $"{models[i].StationName}" + Environment.NewLine + Environment.NewLine;
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

            AnnualEvaluationScoreModel score = view.GetFocusedRow() as AnnualEvaluationScoreModel;

            if (score == null)
                return;

            StationScoreForm form = new StationScoreForm(score.StationId, FieldId, score);
            form.ShowDialog();
        }

        private void bgwDataSource_DoWork(object sender, DoWorkEventArgs e)
        {
            annualEvaluationScoreModelBindingSource.DataSource = Dao.EvaluationScore.GetAnnualEvaluationScoreModels(UpperLocationId, FieldId);
        }

        private void bgwDataSource_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingForm.Close();
        }
    }
}
