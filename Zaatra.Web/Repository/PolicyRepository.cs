using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class PolicyRepository : IRepository<Policy>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public Policy Get(int id)
        {
            return _db.Policies.Find(id);
        }

        public List<Policy> GetAll()
        {
            return _db.Policies.ToList();
        }

        public void Add(Policy entity)
        {
            _db.Policies.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Policy entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.Policies.Find(id);
            _db.Policies.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Policy> FindBy(Expression<Func<Policy, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}