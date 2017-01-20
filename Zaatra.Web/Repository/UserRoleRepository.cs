using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class UserRoleRepository : IRepository<UserRole>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public UserRole Get(int id)
        {
            return _db.UserRoles.Find(id);
        }

        public List<UserRole> GetAll()
        {
            return _db.UserRoles.ToList();
        }

        public void Add(UserRole entity)
        {
            _db.UserRoles.Add(entity);
            _db.SaveChanges();
        }

        public void Update(UserRole entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var package = _db.UserRoles.Find(id);
            _db.UserRoles.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<UserRole> FindBy(Expression<Func<UserRole, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}