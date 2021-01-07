using System;
using System.Collections.Generic;
using System.Linq;

namespace SSTAA.Data
{
    public class FieldDao : SingleKeyDao<Field, int>
    {
        internal FieldDao() { }

        public List<string> GetFieldName()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Fields
                            orderby x.FieldId
                            select x.Name;

                return query.ToList();
            }
        }

        public string GetName(int fieldId)
        {
            using(var context = DbContextCreator.Create())
            {
                return (from x in context.Fields where x.FieldId == fieldId select x.Name).FirstOrDefault();
            }
        }
    }
}