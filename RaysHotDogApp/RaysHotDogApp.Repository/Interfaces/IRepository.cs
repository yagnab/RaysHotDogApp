using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RaysHotDogApp.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        //retrieving data
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        //adding data
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        //remove data
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
