namespace SSTAA.Data
{
    public class Dao
    {
        public static CompetitorDao Competitor { get; set; } = new CompetitorDao();
        public static FieldDao Field { get; set; } = new FieldDao();
        public static FootTrafficDao FootTraffic { get; set; } = new FootTrafficDao();
        public static LandPriceIndexDao LandPriceIndex { get; set; } = new LandPriceIndexDao();
        public static LocationDao Location { get; set; } = new LocationDao();
        public static StationDao Station { get; set; } = new StationDao();
        public static TimetableDao Timetable { get; set; } = new TimetableDao();
        public static EvaluationScoreDao EvaluationScore { get; set; } = new EvaluationScoreDao();
    }
}
