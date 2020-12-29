using System.Data.Entity;

namespace GothamSubway.Data
{
    public abstract class SingleKeyDao<T, K> : BaseDao<T> where T : class
    {
        public T GetByPK(K key)
        {
            using (DbContext context = DbContextCreator.Create())
            {
                return context.Set<T>().Find(key);
            }
        }

        public void DeleteByPK(K key)
        {
            T entity = GetByPK(key);

            if (entity != null)
                Delete(entity);
        }
    }
}
