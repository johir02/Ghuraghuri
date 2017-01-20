using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Repository
{
    public class TicketPersonalRepository:IRepository<TicketPersonalInfo>
    {
        readonly private DatabaseContext _db = new DatabaseContext();

        public TicketPersonalInfo Get(int id)
        {
            throw new NotImplementedException();
        }


        public TicketPersonalInfo GetByTicketId(int ticketId)
        {
            return _db.TicketPersonalInfos.FirstOrDefault(_ => _.AirTicketId == ticketId);
        }

        public List<TicketPersonalInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(TicketPersonalInfo entity)
        {
            _db.TicketPersonalInfos.Add(entity);
            _db.SaveChanges();
        }

        public void Update(TicketPersonalInfo entity)
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

        public IQueryable<TicketPersonalInfo> FindBy(Expression<Func<TicketPersonalInfo, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}