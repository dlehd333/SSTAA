using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class StationDao : SingleKeyDao<Station, int>
    {
        internal StationDao() { }

        public List<string> GetStationName()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Stations
                            orderby x.StationId
                            select x.Name;

                return query.ToList();
            }
        }
        
        public List<string> GetStationNameByGu(int index)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Stations.Where(x => x.LocationId > index && x.LocationId < index+100)
                            select x.Name;

                return query.ToList();
            }

        }

        internal List<Station> GetByUpperLocation(int upperLocationId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Stations
                            where (x.LocationId / 100) == (upperLocationId / 100)
                            select x;

                return query.ToList();
            }
        }
    }
}