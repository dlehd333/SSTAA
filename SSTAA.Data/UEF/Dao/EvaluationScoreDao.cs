using SSTAA.Data.UEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data.UEF.Dao
{
    class EvaluationScoreDao
    {

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
            
            return null;
        }
    }
}
