using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class PackageBookingRepository:IRepository<PackageBooking>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public PackageBooking Get(int id)
        {
            return _db.PackageBookings.Find(id);
        }

        public List<PackageBooking> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(PackageBooking entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PackageBooking entity)
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

        public IQueryable<PackageBooking> FindBy(Expression<Func<PackageBooking, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}