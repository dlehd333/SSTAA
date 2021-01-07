using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class LandPriceIndexDao : SingleKeyDao<LandPriceIndex, int>
    {
        internal LandPriceIndexDao() { }

        internal List<LandPriceIndex> GetByLocation(int locationId)
        {
            using (var context = DbContextCreator.Create())
            {
                return (from x in context.LandPriceIndexes
                       where x.LocationId == locationId
                       select x).ToList();
            }
        }
    }
}