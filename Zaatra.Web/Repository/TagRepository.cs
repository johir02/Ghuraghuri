using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using System.Data.Entity;


namespace Zaatra.Repository
{
    public class TagRepository : IRepository<Tag>
    {
        readonly private DatabaseContext _db = new DatabaseContext();

        public Tag Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAll()
        {
            return _db.Tags.Include("TagCategory").ToList();
        }

        public void Add(Tag entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag entity)
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

        public IQueryable<Tag> FindBy(Expression<Func<Tag, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}