using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using System.Data.Entity;

namespace Zaatra.Repository
{
    public class VisaInformationRepository : IRepository<VisaInformation>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public VisaInformation Get(int id)
        {
            return _db.VisaInformations.Find(id);
        }

        public List<VisaInformation> GetAll()
        {
            return _db.VisaInformations.ToList();
        }

        public void Add(VisaInformation entity)
        {
            _db.VisaInformations.Add(entity);
            _db.SaveChanges();
        }

        public void Update(VisaInformation entity)
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

        public IQueryable<VisaInformation> FindBy(Expression<Func<VisaInformation, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public VisaInformation GetByCountry(int countryId)
        {
            var info = _db.VisaInformations.Include(_ => _.Country).Where(visaInformation => (visaInformation.CountryId == countryId));

            return info.FirstOrDefault();

        }
    }
}