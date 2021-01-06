using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data.UEF.Entities
{
    public class EvaluationPointCalculatingModel
    {
        public double MonthlyLocationPoint { get; set; }
        public double AnnualLocationPoint { get; set; }
        public double IndustryPoint { get; set; }
        public double MonthlyLandPriceIndex { get; set; }
        public double MonthlyTransfer { get; set; }
        public int StationStationId { get; set; }
        public int StationLocationId { get; set; }
        public string StationName { get; set; }
        public DateTime FootTrafficDate { get; set; }
        public int FootTrafficStationId { get; set; }
        public int FootTrafficLocationId { get; set; }
        public int FootTrafficIsWeekend { get; set; }
        public int FootTrafficIsOnBoard { get; set; }
        public int FootTrafficTimetableId { get; set; }
        public int FootTrafficCount { get; set; }
        public int LocationLocationId { get; set; }
        public int CompetitorLocationId { get; set; }
        public int CompetitorCount { get; set; }
        public double WeekendBeforeSixGetOnCountMonthlyAvg { get; set; }
        public double WeekendBeforeSixGetOffCountMonthlyAvg { get; set; }
        public double WeekendThirteenToFourteenGetOnCountMonthlyAvg { get; set; }
        public double WeekendThirteenToFourteenGetOffCountMonthlyAvg { get; set; }
        public double WeekendSixteenToNineteenGetOnCountMonthlyAvg { get; set; }
        public double WeekendSixteenToNineteenGetOffCountMonthlyAvg { get; set; }
        public double WeekdaySevenToEightGetOnCountMonthlyAvg { get; set; }
        public double WeekdaySevenToEightGetOffCountMonthlyAvg { get; set; }
        public double WeekdayNineteenToTwentyGetOnCountMonthlyAvg { get; set; }
        public double WeekdayNineteenToTwentyGetOffCountMonthlyAvg { get; set; }
        public double WeekdayEightToNineGetOnCountMonthlyAvg { get; set; }
        public double WeekdayEightToNineGetOffCountMonthlyAvg { get; set; }
        public double WeekdayEighteenToTwentyGetOnCountMonthlyAvg { get; set; }
        public double WeekdayEighteenToTwentyGetOffCountMonthlyAvg { get; set; }
    }
}