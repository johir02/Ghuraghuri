using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class PackageIncludesRepository : IRepository<PackageIncludes>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public PackageIncludes Get(int id)
        {
            return _db.PackageIncludeses.Find(id);
        }

        public List<PackageIncludes> GetAll()
        {
            return _db.PackageIncludeses.ToList();
        }

        public void Add(PackageIncludes entity)
        {
            _db.PackageIncludeses.Add(entity);
            _db.SaveChanges();
        }

        public void Update(PackageIncludes entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.PackageIncludeses.Find(id);
            _db.PackageIncludeses.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<PackageIncludes> FindBy(Expression<Func<PackageIncludes, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}