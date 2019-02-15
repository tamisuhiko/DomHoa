using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
    public interface IGenericRepository<T>
    {
        T Insert(T obj);
        IEnumerable<T> Insert(List<T> obj);
        T Update(T obj);
        IEnumerable<T> Update(List<T> obj);
        T Delete(T obj);
        IEnumerable<T> Delete(List<T> obj);
        T FindByID(T obj);
    }
}
