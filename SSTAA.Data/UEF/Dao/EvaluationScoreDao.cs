using SSTAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data
{
    public class StationScore
    {
        public string 역이름;
        public DateTime 평가월;
        public int 유동인구;
        public decimal 지가지수;
        public double 평가점수;
    }

    public class EvaluationScoreDao
    {
        public List<AnnualEvaluationScoreModel> GetAnnualEvaluationScoreModels(int upperLocationId, int fieldId)
        {
            List<Station> stations = Dao.Station.GetByUpperLocation(upperLocationId);
            List<AnnualEvaluationScoreModel> models = new List<AnnualEvaluationScoreModel>();

            foreach(var station in stations)
            {
                if (!CheckIsStation(station.StationId))
                    continue;

                AnnualEvaluationScoreModel model = new AnnualEvaluationScoreModel();
                model.StationId = station.StationId;
                model.StationName = station.Name;
                List<FootTraffic> footTraffics = Dao.FootTraffic.GetByStation(station.StationId);
                model.FirstEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear2(footTraffics, model.StationId, fieldId, station.LocationId, 2017);
                model.SecondEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear2(footTraffics, model.StationId, fieldId, station.LocationId, 2018);
                //model.FirstEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear(model.StationId, fieldId, station.LocationId, 2017);
                //model.SecondEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear(model.StationId, fieldId, station.LocationId, 2018);
                //model.ThirdEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear(model.StationId, fieldId, station.LocationId, 2019);
                //model.FourthEvaluationScore = Dao.EvaluationScore.GetEvaluationScoreByYear(model.StationId, fieldId, station.LocationId, 2020);
                models.Add(model);
            }

            models = models.OrderByDescending(x => x.FirstEvaluationScore).ToList();

            int rankCount = 1;

            foreach(var model in models)
            {
                model.Rank = rankCount;
                rankCount++;
            }

            return models;
        }

        private bool CheckIsStation(int stationId)
        {
            using(var context = DbContextCreator.Create())
            {
                if (context.FootTraffics.Where(x => x.StationId == stationId).Count() == 0)
                    return false;
                return true;
            }
        }

        private double GetEvaluationScoreByYear(int stationId, int fieldId, int locationId, int year)
        {
            double evaluationScore = 0.0d;

            for(int i = 1;i <= 12;++i)
            {
                evaluationScore += GetEvaluationScoreByMonth(stationId, fieldId, locationId, year, i);
            }

            return evaluationScore / 12.0d;
        }

        private double GetEvaluationScoreByYear2(List<FootTraffic> footTraffics, int stationId, int fieldId, int locationId, int year)
        {
            double evaluationScore = 0.0d;

            for (int i = 1; i <= 12; ++i)
            {
                evaluationScore += GetEvaluationScoreByMonth2(footTraffics, stationId, fieldId, locationId, year, i);
            }

            return evaluationScore / 12.0d;
        }
        private double GetEvaluationScoreByMonth2(List<FootTraffic> footTraffics, int stationId, int fieldId, int locationId, int year, int month)
        {
            using (var context = DbContextCreator.Create())
            {
                double landPriceIndex = (double)context.LandPriceIndexes.Where(x => x.LocationId == (locationId / 100) * 100 && x.Month.Year == year && x.Month.Month == month).Select(x => x.Index).FirstOrDefault();
                int monthlyTransfer = footTraffics.Where(x => x.StationId == stationId && x.Date.Year == year && x.Date.Month == month).Sum(x => x.Count);

                return (
                    GetLocationPoint2(footTraffics, stationId, new DateTime(year, month, 1)) *
                    GetIndustryPoint(fieldId, locationId) *
                    (landPriceIndex / 100.0d) *
                    (monthlyTransfer * 1.0 / DateTime.DaysInMonth(year, month))
                    ) / 10000.0d;
            }
        }

        private double GetEvaluationScoreByMonth(int stationId, int fieldId, int locationId, int year, int month)
        {
            using (var context = DbContextCreator.Create())
            {
                //if (context.FootTraffics.Where(x => x.StationId == stationId).Count() == 0)
                //    return 0.0d;

                double landPriceIndex = (double)context.LandPriceIndexes.Where(x => x.LocationId == (locationId / 100) * 100 && x.Month.Year == year && x.Month.Month == month).Select(x => x.Index).FirstOrDefault();
                int monthlyTransfer = context.FootTraffics.Where(x => x.StationId == stationId && x.Date.Year == year && x.Date.Month == month).Sum(x => x.Count);

                return (
                    GetLocationPoint(stationId, new DateTime(year, month, 1)) *
                    GetIndustryPoint(fieldId, locationId) *
                    (landPriceIndex / 100.0d) *
                    (monthlyTransfer * 1.0 / DateTime.DaysInMonth(year, month))
                    ) / 10000.0d;
            }
        }

        private double GetIndustryPoint(int fieldId, int locationId)
        {
            using(SSTAAEntities context = DbContextCreator.Create())
            {
                int competitorCount = context.Competitors.Where(x => x.FieldId == fieldId && x.LocationId == locationId).Select(x => x.Count).FirstOrDefault();
                int upperCompetitorCount = context.Competitors.Where(x => x.FieldId == fieldId && (x.LocationId / 100) == (locationId / 100)).Sum(x => x.Count);

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
        }

        public double GetLocationPoint2(List<FootTraffic> footTraffics, int stationId, DateTime month)
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

        public double GetLocationPoint(int stationId, DateTime month)
        {
            List<FootTraffic> footTraffics = Dao.FootTraffic.GetByStationAndMonth(stationId, month);
            
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

        public List<MonthlyEvaluationScoreModel> GetMonthlyEvaluationScore(int UpperId, int FieldId)
        {
            using (SSTAAEntities context = DbContextCreator.Create())
            {
                var Stationquery = from x in context.Stations
                            where (x.LocationId % UpperId < 100 && x.LocationId % UpperId > 0)
                            select new MonthlyEvaluationScoreModel
                            {
                                
                            };
                List<MonthlyEvaluationScoreModel> MonthlyEvaluationPointList = new List<MonthlyEvaluationScoreModel>();
                return MonthlyEvaluationPointList;
            }
            #region EvaluationPoint 내용 작성중
            //    EvaluationPoint = (LocationPoint*IndustryPoint*(MonthlyLandPriceIndex/100)*MonthlyTransfer)/10000
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //    1. LocationScore 계산
            //      ㄱ. Station 테이블에서 (LocationId % UpperId < 100 && LocationId % UpperId > 0) 을 만족하는 Station.StationId 가져오기
            //      ㄴ. Station.StaionId == FootTraffic.StationId인 Date, IsWeekend, IsOnBoard, TimetableId, Count 값을 가져오기
            //      ㄷ. ㄴ에서 가져온 값을 정렬하고 월평균 Count값 구하기 (LINQ Average함수 참고)
            //        a. WeekendBeforeSixGetOnCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 1 && IsOnBoard == 1)
            //        b. WeekendBeforeSixGetOffCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 1 && IsOnBoard == 0)
            //        c. WeekendThirteenToFourteenGetOnCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 9 && IsOnBoard == 1)
            //        d. WeekendThirteenToFourteenGetOffCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 9 && IsOnBoard == 0)
            //        e. WeekendSixteenToNineteenGetOnCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 14 && IsOnBoard == 1)
            //        f. WeekendSixteenToNineteenGetOffCountMonthlyAvg 의 조건 
            //              (IsWeekend == 1 && TimetableId == 14 && IsOnBoard == 0)
            //        g. WeekdaySevenToEightGetOnCountMonthlyAvg 의 조건 ------------------- 여기서부터 평일
            //              (IsWeekend == 0 && TimetableId == 3 && IsOnBoard == 1)
            //        h. WeekdaySevenToEightGetOffCountMonthlyAvg 의 조건 
            //              (IsWeekend == 0 && TimetableId == 3 && IsOnBoard == 0)
            //        i. WeekdayNineteenToTwentyGetOnCountMonthlyAvg 의 조건 
            //              (IsWeekend == 0 && TimetableId == 15 && IsOnBoard == 1)
            //        j. WeekdayNineteenToTwentyGetOffCountMonthlyAvg 의 조건 
            //              (IsWeekend == 0 && TimetableId == 15 && IsOnBoard == 0)
            //        k. WeekdayEightToNineGetOnCountMonthlyAvg 의 조건
            //              (IsWeekend == 0 && TimetableId == 4 && IsOnBoard == 1)
            //        l. WeekdayEightToNineGetOffCountMonthlyAvg 의 조건
            //              (IsWeekend == 0 && TimetableId == 4 && IsOnBoard == 0)
            //        m. WeekdayEighteenToTwentyGetOnCountMonthlyAvg 의 조건
            //              (IsWeekend == 0 && TimetableId == 14 && IsOnBoard == 1)
            //        n. WeekdayEighteenToTwentyGetOffCountMonthlyAvg 의 조건
            //              (IsWeekend == 0 && TimetableId == 14 && IsOnBoard == 0)
            //      ㄹ. 조건에 맞추어 LocationScore 값 부여하기
            //        a. if((WeekendBeforeSixGetOnCountMonthlyAvg - WeekendBeforeSixGetOffCountMonthlyAvg) > 2000 || (WeekendThirteenToFourteenGetOnCountMonthlyAvg - WeekendThirteenToFourteenGetOffCountMonthlyAvg) < -2000 && (WeekendSixteenToNineteenGetOnCountMonthlyAvg - WeekendSixteenToNineteenGetOffCountMonthlyAvg) < -2000)
            //                  LocationScore = 3;
            //          else if((WeekdaySevenToEightGetOnCountMonthlyAvg - WeekdaySevenToEightGetOffCountMonthlyAvg) > 2000 && (WeekdayNineteenToTwentyGetOnCountMonthlyAvg - WeekdayNineteenToTwentyGetOffCountMonthlyAvg) < -2000)
            //                  LocationScore = 1.6;
            //          else if((WeekdayEightToNineGetOnCountMonthlyAvg - WeekdayEightToNineGetOffCountMonthlyAvg) < -2000 && (WeekdayEighteenToTwentyGetOnCountMonthlyAvg - WeekdayNineteenToTwentyGetOffCountMonthlyAvg) < -2000)
            //                  LocationScore = 1.4;
            //          else 
            //                  LocationScore = 1;
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //    2. IndurstryScore 계산
            //      ㄱ. Competitor 테이블에서 (Competitor.FieldId == FieldId && (LocationId % UpperId < 100 && LocationId % UpperId > 0))를 만족하는 LocationId, Count값 가져오기
            //      ㄴ. ㄱ.에서 가져온 Count의 합계를 구한다. 합계 = UpperLocationCount(해당구 동종업 점포수) (LINQ Sum 참고)
            //      ㄹ. IndustryRatio = ((ㄱ. 에서 가져온 Count값) / UpperLocationCount)*100
            //      ㅁ. IndustryRatio를 기준으로 아래 조건에 따라 IndustryScore 값 부여
            //        a. if(IndustryRatio < 8 && IndustryRatio >= 6)
            //                  IndustryScore = 1.1
            //          else if(IndustryRatio < 6 && IndustryRatio >= 4)
            //                  IndustryScore = 1.2
            //          else if(IndustryRatio < 4 && IndustryRatio >= 2)
            //                  IndustryScore = 1.3
            //          else if(IndustryRatio < 2 && IndustryRatio >= 0)
            //                  IndustryScore = 1.4
            //          else
            //                  IndustryScore = 1
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            #endregion
        }

        public List<MonthlyEvaluationScoreModel> GetMonthlyEvaluationScoreModels(int stationId, int fieldId)
        {
            List<MonthlyEvaluationScoreModel> models = new List<MonthlyEvaluationScoreModel>();
            List<FootTraffic> footTraffics = Dao.FootTraffic.GetByStation(stationId);
            Station station = Dao.Station.GetByPK(stationId);
            List<LandPriceIndex> landPriceIndices = Dao.LandPriceIndex.GetByLocation(station.LocationId / 100 * 100);
            List<DateTime> month = footTraffics.Where(x => x.Date < new DateTime(2019, 1, 1)).Select(x => new DateTime(x.Date.Year, x.Date.Month, 1)).Distinct().ToList();

            for(int i =0; i < month.Count; i++)
            {
                MonthlyEvaluationScoreModel model = new MonthlyEvaluationScoreModel();
                model.Date = month[i];
                model.FloatingPopulation = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month).Sum(x => x.Count);

                model.FloationPopulationBySevenToEightOnBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 3 && x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationBySevenToEightOffBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 3 && !x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationByEighteenToNineteenOnBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 14 && x.IsOnBoard).Sum(x => x.Count);
                model.FloationPopulationByEighteenToNineteenOffBoard = footTraffics.Where(x => x.Date.Year == month[i].Year && x.Date.Month == month[i].Month && x.TimetableId == 14 && !x.IsOnBoard).Sum(x => x.Count);

                model.MonthlyLandPriceIndex = (double)landPriceIndices.Where(x => x.Month.Year == month[i].Year && x.Month.Month == month[i].Month).Select(x => x.Index).FirstOrDefault();
                model.MonthlyEvaluationScore = (
                    GetLocationPoint(stationId, new DateTime(month[i].Year, month[i].Month, 1)) *
                    GetIndustryPoint(fieldId, station.LocationId) *
                    (model.MonthlyLandPriceIndex / 100.0d) *
                    (model.FloatingPopulation * 1.0 / DateTime.DaysInMonth(month[i].Year, month[i].Month))
                    ) / 10000.0d;

                models.Add(model);
            }

            return models;
        }

        public void GetStationScore(int stationId, int locationId, int fieldId)
        {
            using (SSTAAEntities context = DbContextCreator.Create())
            {
                StationScore stationScore = new StationScore();

                stationScore.역이름 = context.Stations.Where(x => x.StationId == stationId).Select(x => x.Name).FirstOrDefault();
                stationScore.평가월 = new DateTime(2017, 1, 1);
                stationScore.유동인구 = context.FootTraffics.Where(x => x.StationId == stationId && x.Date.Year == 2017 && x.Date.Month == 1).Sum(x => x.Count);
                stationScore.지가지수 = context.LandPriceIndexes.Where(x => x.LocationId == locationId && x.Month.Year == 2017 && x.Month.Month == 1).Select(x => x.Index).FirstOrDefault();
                stationScore.평가점수 = (GetLocationPoint(stationId, stationScore.평가월) * GetIndustryPoint(fieldId, locationId) * ((double)stationScore.지가지수 / 100.0d) * (stationScore.유동인구 * 1.0 / DateTime.DaysInMonth(stationScore.평가월.Year, stationScore.평가월.Month))) / 10000.0d;
            }

        }
    }
}
