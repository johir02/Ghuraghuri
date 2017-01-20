using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class PackageImageRepository : IRepository<PackageImage>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public PackageImage Get(int id)
        {
            return _db.PackageImages.Find(id);
        }

        public List<PackageImage> GetAll()
        {
            return _db.PackageImages.ToList();
        }

        public void Add(PackageImage entity)
        {
            _db.PackageImages.Add(entity);
            _db.SaveChanges();
        }

        public void Update(PackageImage entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.PackageImages.Find(id);
            _db.PackageImages.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<PackageImage> FindBy(Expression<Func<PackageImage, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}