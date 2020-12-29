namespace GothamSubway.Data
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/GothamSubway.csdl|res://*/GothamSubway.ssdl|res://*/GothamSubway.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=GothamSubway;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework&\"";

        public static GothamSubwayEntities Create()
        {
            GothamSubwayEntities context = new GothamSubwayEntities(ConnectionString);

            return context;
        }
    }

    public partial class GothamSubwayEntities
    {
        public GothamSubwayEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
