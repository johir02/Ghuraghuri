using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using System.Data.Entity;

namespace Zaatra.Repository
{
    public class PackageTagRepository : IRepository<PackageTag>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public PackageTag Get(int id)
        {
            return _db.PackageTags.Find(id);
        }

        public List<PackageTag> GetAll()
        {
            var  pack =_db.PackageTags.Include(pt=>pt.Tag.TagCategory).ToList();
            return pack;
        }

        public void Add(PackageTag entity)
        {
            _db.PackageTags.Add(entity);
            _db.SaveChanges();
        }

        public void Update(PackageTag entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.PackageTags.Find(id);
            _db.PackageTags.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<PackageTag> FindBy(Expression<Func<PackageTag, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}