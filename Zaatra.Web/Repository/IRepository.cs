using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll(); 
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);


    }
}