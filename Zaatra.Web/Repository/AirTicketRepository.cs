using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI.WebControls;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class AirTicketRepository
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public AirTicket Get(int id)
        {
            return _db.AirTickets.Find(id);
        }

        public List<AirTicket> GetAll()
        {
            return _db.AirTickets.OrderByDescending(_=>_.Id).ToList();
        }


        public int Add(AirTicket entity)
        {
            _db.AirTickets.Add(entity);
            _db.SaveChanges();
            return entity.Id;
        }

        public void Update(AirTicket entity)
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

        public IQueryable<AirTicket> FindBy(Expression<Func<AirTicket, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}