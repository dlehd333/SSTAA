using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data.UEF.Entities
{
    public class AnnualEvaluationScoreModel
    {
        public int Ranking { get; set; }
        public int StaionName { get; set; }
        public int FirstEvaluationScore { get; set; }
        public int SecondEvaluationScore { get; set; }
        public int ThirdEvaluationScore { get; set; }
        public int FourthEvaluationScore { get; set; }
    }
    public class MonthlyEvaluationScoreModel
    {
        public DateTime Date { get; }
        public int FloatingPopulation { get; set; }
        public double MonthlyLandPriceIndex { get; }
        public double MonthlyEvaluationScore { get; set; }
    }
}