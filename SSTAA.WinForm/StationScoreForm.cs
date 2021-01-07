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
    public partial class StationScoreForm : XtraForm
    {
        public int StationId { get; set; }
        public int FieldId { get; set; }
        public AnnualEvaluationScoreModel Model { get; set; }
        public LoadingForm LoadingForm { get; set; } = new LoadingForm();
        public StationScoreForm()
        {
            InitializeComponent();
        }

        public StationScoreForm(int stationId, int fieldId, AnnualEvaluationScoreModel model) : this()
        {
            StationId = stationId;
            FieldId = fieldId;
            Model = model;
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
            labelControl2.Text = $"{Model.StationName}" + Environment.NewLine + "평가 상세정보(월별)";

            lblRank.Text = $"{Model.Rank}위";
            lblScore.Text = $"{Model.FirstEvaluationScore:0.00}";

            labelControl1.Text = $"{Model.StationName}" + Environment.NewLine + "기대점수";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bgwDataSource_DoWork(object sender, DoWorkEventArgs e)
        {
            monthlyEvaluationScoreModelBindingSource.DataSource = Dao.EvaluationScore.GetMonthlyEvaluationScoreModels(StationId, FieldId);
        }

        private void bgwDataSource_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingForm.Close();
        }
    }
}
