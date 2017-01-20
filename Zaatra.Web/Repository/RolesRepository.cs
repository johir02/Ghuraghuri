using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using Zaatra.Models;
using Roles = Zaatra.Models.Roles;

namespace Zaatra.Repository
{
    public class RolesRepository : IRepository<Roles>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public Roles Get(int id)
        {
            return _db.Roleses.Find(id);
        }

        public List<Roles> GetAll()
        {
            return _db.Roleses.ToList();
        }

        public void Add(Roles entity)
        {
            _db.Roleses.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Roles entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.Roleses.Find(id);
            _db.Roleses.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Roles> FindBy(Expression<Func<Roles, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}