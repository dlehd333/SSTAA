using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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

        
        //퉅팁 테스트 구간
        private string[] columnToolTipArray = new string[]
        {
            "순위",
            "",
            "first evaluation score",
            "second evaluation score",
            "",
            "fourth evaluation score"
        };

        //셀 툴팁
        private string GetCellToolTip (GridView gridView, int rowHandle, GridColumn sourceColumn)
        {
            string toolTip = gridView.GetRowCellDisplayText(rowHandle, sourceColumn);

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.VisibleIndex < 0)
                {
                    toolTip += string.Format
                    (
                        "\r\n {0}: {1}",
                        column.GetTextCaption(),
                        gridView.GetRowCellDisplayText(rowHandle, sourceColumn)
                    );
                }
            }
            return toolTip;
        }

        //컬럼 툴팁
        private string GetColumnToolTip(GridView gridView, GridColumn sourceColumn)
        {
            string toolTip = this.columnToolTipArray[gridView.Columns.IndexOf(sourceColumn)];

            if (toolTip == "")
                toolTip = sourceColumn.GetTextCaption();

            return toolTip;
        }

        //툴팁 이벤트
        private void toolTipController1_GetActiveObjectInfo(object sender,
ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != grdScore) return;

            ToolTipControlInfo toolTipInfo = null;

            try
            {
                GridView gridView = grdScore.GetViewAt(e.ControlMousePosition) as GridView;

                if (gridView == null)
                    return;

                GridHitInfo gridHitInfo = gridView.CalcHitInfo(e.ControlMousePosition);

                if (gridHitInfo.InRowCell)
                {
                    toolTipInfo = new ToolTipControlInfo
                    (
                        new CellToolTipInfo(gridHitInfo.RowHandle, gridHitInfo.Column, "셀"), GetCellToolTip(gridView, gridHitInfo.RowHandle, gridHitInfo.Column)
                    );
                    return;
                }
            }
            
            finally
            {
                e.Info = toolTipInfo;
            }
        }
    }
}
