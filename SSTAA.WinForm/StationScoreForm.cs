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
        public StationScoreForm()
        {
            InitializeComponent();
        }

        public StationScoreForm(int stationId, int fieldId, AnnualEvaluationScoreModel model) : this()
        {
            StationId = stationId;
            FieldId = fieldId;

            lblRank.Text = $"{model.Rank}위";
            lblScore.Text = $"{model.FirstEvaluationScore:0.00}";

            monthlyEvaluationScoreModelBindingSource.DataSource = Dao.EvaluationScore.GetMonthlyEvaluationScoreModels(StationId, FieldId);
        }
    }
}
