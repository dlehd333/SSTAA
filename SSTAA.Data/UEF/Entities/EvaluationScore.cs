using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data
{
    public class AnnualEvaluationScoreModel
    {
        public int Rank { get; set; }
        public int StationId { get; set; }
        public string StationName { get; set; }
        public double FirstEvaluationScore { get; set; }
        public double SecondEvaluationScore { get; set; }
        public double ThirdEvaluationScore { get; set; }
        public double FourthEvaluationScore { get; set; }
    }
    public class MonthlyEvaluationScoreModel
    {
        public DateTime Date { get; set; }
        public int FloatingPopulation { get; set; }
        public int FloationPopulationBySevenToEightOnBoard { get; set; }
        public int FloationPopulationBySevenToEightOffBoard { get; set; }
        public int FloationPopulationByEighteenToNineteenOnBoard { get; set; }
        public int FloationPopulationByEighteenToNineteenOffBoard { get; set; }
        public double MonthlyLandPriceIndex { get; set; }
        public double MonthlyEvaluationScore { get; set; }
    }
}