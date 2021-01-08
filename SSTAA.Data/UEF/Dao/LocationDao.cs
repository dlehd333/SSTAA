using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class LocationDao : SingleKeyDao<Location, int>
    {
        internal LocationDao() { }

        public List<string> GetGuName()
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

        public string GetName(int locationId)
        {
            using (var context = DbContextCreator.Create())
            {
                return (from x in context.Locations where x.LocationId == locationId select x.Name).FirstOrDefault();
            }
        }

        public List<Location> GetByGu()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Locations.Where(x => x.UpperId == null).ToList();
            }
        }
    }
}