using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PrimarySchoolsContext _dbContext;
        public GenericRepository(PrimarySchoolsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Delete(T obj)
        {
            _dbContext.Set<T>().Remove(obj);
            return obj;
        }

        public IEnumerable<T> Delete(List<T> obj)
        {
            _dbContext.Set<List<T>>().Remove(obj);
            return obj;
        }

        public T FindByID(T obj)
        {
            return _dbContext.Set<T>().Find(obj);
        }

        public T Insert(T obj)
        {
            _dbContext.Set<T>().Add(obj);
            return obj;
        }

        public IEnumerable<T> Insert(List<T> obj)
        {
            _dbContext.Set<List<T>>().Add(obj);
            return obj;
        }

        public T Update(T obj)
        {
            _dbContext.Set<T>().Update(obj);
            return obj;
        }

        public IEnumerable<T> Update(List<T> obj)
        {
            _dbContext.Set<List<T>>().Update(obj);
            return obj;
        }
    }
}
