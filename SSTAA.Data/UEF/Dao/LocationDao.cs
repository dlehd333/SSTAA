using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class LocationDao : SingleKeyDao<Location, int>
    {
        internal LocationDao() { }

        public List<string> GetGu()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Locations
                            orderby x.LocationId
                            where x.UpperId == null
                            select x.Name;

                return query.ToList();
            }
        }
    }
}