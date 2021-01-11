using SSTAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data
{
    public class EvaluationScoreDao
    {
        public List<AnnualEvaluationScoreModel> GetAnnualEvaluationScoreModels(int upperLocationId, int fieldId)
        {
            List<Station> stations = Dao.Station.GetByUpperLocation(upperLocationId);
            List<LandPriceIndex> landPriceIndices = Dao.LandPriceIndex.GetByLocation(upperLocationId);
            List<AnnualEvaluationScoreModel> models = new List<AnnualEvaluationScoreModel>();
            List<Competitor> competitors = Dao.Competitor.GetByField(fieldId);

            foreach(var station in stations)
            {
                List<FootTraffic> footTraffics = Dao.FootTraffic.GetByStation(station.StationId);

                if (footTraffics == null)
                    continue;

                AnnualEvaluationScoreModel model = new AnnualEvaluationScoreModel();
                model.StationId = station.StationId;
                model.StationName = station.Name;
                model.FirstEvaluationScore = GetEvaluationScoreByYear(footTraffics, station, landPriceIndices, competitors, 2017);
                model.SecondEvaluationScore = GetEvaluationScoreByYear(footTraffics, station, landPriceIndices, competitors, 2018);
                model.ThirdEvaluationScore = GetEvaluationScoreByYear(footTraffics, station, landPriceIndices, competitors, 2019);
                model.FourthEvaluationScore = GetEvaluationScoreByYear(footTraffics, station, landPriceIndices, competitors, 2020);
                models.Add(model);
            }

            models = models.OrderByDescending(x => x.FourthEvaluationScore).ToList();

            int rankCount = 1;

            foreach(var model in models)
            {
                model.Rank = rankCount;
                rankCount++;
            }

            return models;
        }

        private double GetEvaluationScoreByYear
            (List<FootTraffic> footTraffics, 
            Station station,
            List<LandPriceIndex> landPriceIndices,
            List<Competitor> competitors, int year)
        {
            double evaluationScore = 0.0d;

            int monthCount = (year < 2020 ? 12 : 8);

            for (int i = 1; i <= monthCount; ++i)
            {
                evaluationScore += GetEvaluationScoreByMonth(footTraffics, station, landPriceIndices, competitors, year, i);
            }

            return evaluationScore / (monthCount * 1.0d);
        }
        private double GetEvaluationScoreByMonth
            (List<FootTraffic> footTraffics,
            Station station,
            List<LandPriceIndex> landPriceIndices,
            List<Competitor> competitors, int year, int month)
        {

            if (landPriceIndices.Find(x => x.Month.Year == year && x.Month.Month == month) == null ||
                footTraffics.Find(x => x.Date.Year == year && x.Date.Month == month) == null)
                return 0.0d;

            double landPriceIndex = (double)landPriceIndices.Find(x => x.Month.Year == year && x.Month.Month == month).Index;
            int monthlyTransfer = footTraffics.FindAll(x => x.StationId == station.StationId && x.Date.Year == year && x.Date.Month == month).Sum(x => x.Count);

            return 
                (
                    GetLocationPoint(footTraffics, station.StationId, new DateTime(year, month, 1)) *
                    GetIndustryPoint(competitors, station.LocationId) *
                    (landPriceIndex / 100.0d) *
                    (monthlyTransfer * 1.0 / DateTime.DaysInMonth(year, month))
                ) / 10000.0d;
        }

        private double GetIndustryPoint(List<Competitor> competitors, int locationId)
        {
                int competitorCount = competitors.Where(x => x.LocationId == locationId).Select(x => x.Count).FirstOrDefault();
                int upperCompetitorCount = competitors.Where(x => (x.LocationId / 100) == (locationId / 100)).Sum(x => x.Count);

                double industryRatio = (competitorCount / (double)upperCompetitorCount) * 100.0d;

                if (industryRatio >= 8)
                    return 0.4d;
                else if (industryRatio < 8 && industryRatio >= 6)
                    return 1.1d;
                else if (industryRatio < 6 && industryRatio >= 4)
                    return 1.2d;
                else if (industryRatio < 4 && industryRatio >= 2)
                    return 1.3d;
                else if (industryRatio < 2 && industryRatio >= 0)
                    return 1.4d;
                else
                    return 1.0d;                       
        }

        public double GetLocationPoint(List<FootTraffic> footTraffics, int stationId, DateTime month)
        {
            List<FootTraffic> traffics = footTraffics.FindAll(x => x.Date.Year == month.Year && x.Date.Month == month.Month);

            double WeekendBeforeSixGetOnCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 1 && x.IsOnBoard).Average(x => x.Count);
            double WeekendBeforeSixGetOffCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 1 && !x.IsOnBoard).Average(x => x.Count);
            double WeekendThirteenToFourteenGetOnCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 9 && x.IsOnBoard).Average(x => x.Count);
            double WeekendThirteenToFourteenGetOffCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 9 && !x.IsOnBoard).Average(x => x.Count);
            double WeekendSixteenToNineteenGetOnCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 14 && x.IsOnBoard).Average(x => x.Count);
            double WeekendSixteenToNineteenGetOffCountMonthlyAvg = footTraffics.FindAll(x => x.IsWeekend && x.TimetableId == 14 && !x.IsOnBoard).Average(x => x.Count);
            double WeekdaySevenToEightGetOnCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 3 && x.IsOnBoard).Average(x => x.Count);
            double WeekdaySevenToEightGetOffCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 3 && !x.IsOnBoard).Average(x => x.Count);
            double WeekdayNineteenToTwentyGetOnCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 15 && x.IsOnBoard).Average(x => x.Count);
            double WeekdayNineteenToTwentyGetOffCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 15 && !x.IsOnBoard).Average(x => x.Count);
            double WeekdayEightToNineGetOnCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 4 && x.IsOnBoard).Average(x => x.Count);
            double WeekdayEightToNineGetOffCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 4 && !x.IsOnBoard).Average(x => x.Count);
            double WeekdayEighteenToTwentyGetOnCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 14 && x.IsOnBoard).Average(x => x.Count);
            double WeekdayEighteenToTwentyGetOffCountMonthlyAvg = footTraffics.FindAll(x => !x.IsWeekend && x.TimetableId == 14 && !x.IsOnBoard).Average(x => x.Count);
            
            if ((WeekendBeforeSixGetOnCountMonthlyAvg - WeekendBeforeSixGetOffCountMonthlyAvg) > 2000 || ((WeekendThirteenToFourteenGetOnCountMonthlyAvg - WeekendThirteenToFourteenGetOffCountMonthlyAvg) < -2000 && (WeekendSixteenToNineteenGetOnCountMonthlyAvg - WeekendSixteenToNineteenGetOffCountMonthlyAvg) < -2000))
                return 3.0d;
            else if ((WeekdaySevenToEightGetOnCountMonthlyAvg - WeekdaySevenToEightGetOffCountMonthlyAvg) > 2000 && (WeekdayNineteenToTwentyGetOnCountMonthlyAvg - WeekdayNineteenToTwentyGetOffCountMonthlyAvg) < -2000)
                return 1.6d;
            else if ((WeekdayEightToNineGetOnCountMonthlyAvg - WeekdayEightToNineGetOffCountMonthlyAvg) < -2000 && (WeekdayEighteenToTwentyGetOnCountMonthlyAvg - WeekdayNineteenToTwentyGetOffCountMonthlyAvg) < -2000)
                return 1.4d;
            else
                return 1.0d;
        }

        public List<MonthlyEvaluationScoreModel> GetMonthlyEvaluationScoreModels(int stationId, int fieldId)
        {
            List<FootTraffic> footTraffics = Dao.FootTraffic.GetByStation(stationId);
            Station station = Dao.Station.GetByPK(stationId);
            List<LandPriceIndex> landPriceIndices = Dao.LandPriceIndex.GetByLocation(station.LocationId / 100 * 100);
            List<DateTime> month = footTraffics.Where(x => x.Date < new DateTime(2020, 9, 1)).Select(x => new DateTime(x.Date.Year, x.Date.Month, 1)).Distinct().ToList();
            List<Competitor> competitors = Dao.Competitor.GetByField(fieldId);

            List<MonthlyEvaluationScoreModel> models = new List<MonthlyEvaluationScoreModel>();
            
            for (int i =0; i < month.Count; i++)
            {
                MonthlyEvaluationScoreModel model = new MonthlyEvaluationScoreModel();
                model.Date = month[i];
                model.FloatingPopulation = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month).Sum(x => x.Count);

                model.FloationPopulationBySevenToEightOnBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 3 && x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationBySevenToEightOffBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 3 && !x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationByEighteenToNineteenOnBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 14 && x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationByEighteenToNineteenOffBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 14 && !x.IsOnBoard).Sum(x => x.Count);

                model.MonthlyLandPriceIndex = (double)landPriceIndices.Where(x => x.Month.Year == month[i].Year && x.Month.Month == month[i].Month).Select(x => x.Index).FirstOrDefault();
                model.MonthlyEvaluationScore = 
                    (
                        GetLocationPoint(footTraffics, station.StationId, new DateTime(month[i].Year, month[i].Month, 1)) *
                        GetIndustryPoint(competitors, station.LocationId) *
                        (model.MonthlyLandPriceIndex / 100.0d) *
                        (model.FloatingPopulation * 1.0 / DateTime.DaysInMonth(month[i].Year, month[i].Month))
                    ) / 10000.0d;
                model.IndustryRatio = GetIndustryPoint(competitors, station.LocationId);
                model.LoationPoint = GetLocationPoint(footTraffics, station.StationId, new DateTime(month[i].Year, month[i].Month, 1));
                models.Add(model);
            }

            return models;
        }
    }
}
