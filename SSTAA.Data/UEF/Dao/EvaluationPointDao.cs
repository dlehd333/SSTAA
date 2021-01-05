using SSTAA.Data.UEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTAA.Data.UEF.Dao
{
    class EvaluationPointDao
    {

        //public List<EvaluationPointCalculatingModel> GetEvaluationPoint(int UpperId, int FieldId)
        //{
            #region EvaluationPoint 내용 작성중
            //    EvaluationPoint = (LocationPoint*IndustryPoint*(MonthlyLendPriceIndex/100)*MonthlyTransfer)/10000

            //    1. LocationPoint 계산
            //      ㄱ. Station 테이블에서 (LocationId % UpperId < 100 && LocationId % UpperId > 0) 을 만족하는 Station.StationId 가져오기
            //      ㄴ. Station.StaionId == FootTraffic.StationId인 Date, IsWeekend, IsOnBoard, TimetableId, Count 값을 가져오기
            //      ㄷ. ㄴ에서 가져온 값을 년도별, 월별로 분류하고 월평균 Count값 구하기 (LINQ Average함수 참고)
            //      ㄹ. 조건에 맞추어 LocationPoint 값 부여하기
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //          a. 3 Points : Citycenter
            //    
            //                  FootTraffic.Count의 월평균값                             조건
            //             - WeekendBeforeSixGetOnCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 1 && IsOnBoard == 1)
            //             - WeekendBeforeSixGetOffCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 1 && IsOnBoard == 0)
            //             - WeekendThirteenToFourteenGetOnCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 9 && IsOnBoard == 1)
            //             - WeekendThirteenToFourteenGetOffCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 9 && IsOnBoard == 0)
            //             - WeekendSixteenToNineteenGetOnCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 14 && IsOnBoard == 1)
            //             - WeekendSixteenToNineteenGetOffCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 14 && IsOnBoard == 0)

            //    if((WeekendBeforeSixGetOnCountMonthlyAvg - WeekendBeforeSixGetOffCountMonthlyAvg) > 2000 || (WeekendThirteenToFourteenGetOnCountMonthlyAvg - WeekendThirteenToFourteenGetOffCountMonthlyAvg) < -2000 && (WeekendSixteenToNineteenGetOnCountMonthlyAvg - WeekendSixteenToNineteenGetOffCountMonthlyAvg) < -2000)
            //                  LocationPoint = 3;
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //          b. 1.6 Points : Uptown
            //    
            //                  FootTraffic.Count의 월평균값                             조건
            //             - WeekdaySevenToEightGetOnCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 3 && IsOnBoard == 1)
            //             - WeekdaySevenToEightGetOffCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 3 && IsOnBoard == 0)
            //             - WeekdayNineteenToTwentyGetOnCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 15 && IsOnBoard == 1)
            //             - WeekdayNineteenToTwentyGetOffCountMonthlyAvg = (IsWeekend == 1 && TimetableId == 15 && IsOnBoard == 0)

            //    else if((WeekdaySevenToEightGetOnCountMonthlyAvg - WeekdaySevenToEightGetOffCountMonthlyAvg) > 2000 && (WeekdayNineteenToTwentyGetOnCountMonthlyAvg - WeekdayNineteenToTwentyGetOffCountMonthlyAvg) < -2000)
            //                  LocationPoint = 1.6;
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //          c. 1.4 Points : Business District
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //          d. 1 Point : None
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //    2. IndurstryPoint 계산
            //      ㄱ. Competitor 테이블에서 (Competitor.FieldId == FieldId && (LocationId % UpperId < 100 && LocationId % UpperId > 0))를 만족하는 LocationId, Count값 가져오기
            //      ㄴ. ㄱ.에서 가져온 Count의 합계를 구한다. 합계 = UpperLocationCount(해당구 동종업 점포수) (LINQ Sum 참고)
            //
            //      ㄷ. 조건에 맞추어 IndustryPoint 값 부여
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            //             - if (IndustryRatio > 8 && IndustryRatio < 6)
            //                  IndustryPoint = 1.1
            //    -----------------------------------------------------------------------------------------------------------------------------------------
            #endregion

        //}
    }
}
