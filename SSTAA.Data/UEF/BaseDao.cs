﻿using System.Collections.Generic;
using System.Linq;

namespace GothamSubway.Data
{
    public class BaseDao<T> where T : class
    {
        public int GetCount()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Set<T>().Count();
            }
        }

        public List<T> GetAll()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var context = DbContextCreator.Create())
            {
                context.Set<T>().Add(entity);

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = DbContextCreator.Create())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = DbContextCreator.Create())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
