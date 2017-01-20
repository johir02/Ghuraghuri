using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class ChargeTypeRepository : IRepository<ChargeType>
    {
        readonly private DatabaseContext _db = new DatabaseContext();

        public ChargeType Get(int id)
        {
            return _db.ChargeTypes.Find(id);
        }

        public List<ChargeType> GetAll()
        {
            return _db.ChargeTypes.ToList();
        }

        public void Add(ChargeType entity)
        {
            _db.ChargeTypes.Add(entity);
            _db.SaveChanges();
        }

        public void Update(ChargeType entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var chargeType = _db.ChargeTypes.Find(id);
            _db.ChargeTypes.Remove(chargeType);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<ChargeType> FindBy(Expression<Func<ChargeType, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}