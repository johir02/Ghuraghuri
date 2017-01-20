using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class PackageConditionRepository : IRepository<PolicyCondition>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public PolicyCondition Get(int id)
        {
            return _db.PackageConditions.Find(id);
        }

        public List<PolicyCondition> GetAll()
        {
            return _db.PackageConditions.ToList();
        }

        public void Add(PolicyCondition entity)
        {
            _db.PackageConditions.Add(entity);
            _db.SaveChanges();
        }

        public void Update(PolicyCondition entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.PackageConditions.Find(id);
            _db.PackageConditions.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<PolicyCondition> FindBy(Expression<Func<PolicyCondition, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}