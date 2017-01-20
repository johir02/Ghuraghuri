using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class VendorRepository : IRepository<Vendor>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public Vendor Get(int id)
        {
            return _db.Vendors.Find(id);
        }

        public List<Vendor> GetAll()
        {
            return _db.Vendors.ToList();
        }

        public void Add(Vendor entity)
        {
            _db.Vendors.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Vendor entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.Vendors.Find(id);
            _db.Vendors.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Vendor> FindBy(Expression<Func<Vendor, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}