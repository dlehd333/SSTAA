namespace SSTAA.Data
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/SSTAA.csdl|res://*/SSTAA.ssdl|res://*/SSTAA.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=SSTAA;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static SSTAAEntities Create()
        {
            SSTAAEntities context = new SSTAAEntities(ConnectionString);

            return context;
        }
    }

    public partial class SSTAAEntities
    {
        public SSTAAEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
