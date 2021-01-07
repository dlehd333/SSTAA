using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class CompetitorDao : SingleKeyDao<Competitor,int>
    {
        internal CompetitorDao() { }

        internal List<Competitor> GetByField(int fieldId)
        {
            using(var context = DbContextCreator.Create())
            {
                return context.Competitors.Where(x => x.FieldId == fieldId).ToList();
            }
        }
    }
}