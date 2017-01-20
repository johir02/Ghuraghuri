using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class CountryRepository : IRepository<Country>
    {
        readonly private DatabaseContext _db = new DatabaseContext();

        public Country Get(int id)
        {
            return _db.Countries.Find(id);
        }

        public List<Country> GetAll()
        {
            return _db.Countries.ToList();
        }

        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Country> FindBy(Expression<Func<Country, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}