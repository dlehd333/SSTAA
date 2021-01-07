using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class FootTrafficDao : SingleKeyDao<FootTraffic, int>
    {
        internal FootTrafficDao() { }

        public List<FootTraffic> GetByStationAndMonth(int stationId, DateTime month)
        {
            using(SSTAAEntities context = DbContextCreator.Create())
            {
                return context.FootTraffics.Where(x => x.StationId == stationId && x.Date.Year == month.Year && x.Date.Month == month.Month).ToList();
            }
        }

        public List<FootTraffic> GetByStation(int stationId)
        {
            using(var context = DbContextCreator.Create())
            {
                var query = context.FootTraffics.Where(x => x.StationId == stationId);

                if (query.FirstOrDefault() == null)
                    return null;

                else 
                    return query.ToList();
            }
        }
    }
}