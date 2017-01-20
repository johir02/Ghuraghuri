using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class DayDescriptionRepository : IRepository<DayDescription>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public DayDescription Get(int id)
        {
            return _db.DayDescriptions.Find(id);
        }

        public List<DayDescription> GetAll()
        {
            return _db.DayDescriptions.ToList();
        }

        public void Add(DayDescription entity)
        {
            _db.DayDescriptions.Add(entity);
            _db.SaveChanges();
        }

        public void Update(DayDescription entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.Packages.Find(id);
            _db.Packages.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<DayDescription> FindBy(Expression<Func<DayDescription, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}