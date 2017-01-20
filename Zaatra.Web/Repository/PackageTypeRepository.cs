using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using Type = Zaatra.Models.Type;

namespace Zaatra.Repository
{
    public class PackageTypeRepository : IRepository<Type>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public Type Get(int id)
        {
            return _db.Types.Find(id);
        }

        public List<Type> GetAll()
        {
            return _db.Types.ToList();
        }

        public void Add(Type entity)
        {
            _db.Types.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Type entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.Types.Find(id);
            _db.Types.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Type> FindBy(Expression<Func<Type, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}