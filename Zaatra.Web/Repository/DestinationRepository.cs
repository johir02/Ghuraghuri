using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using Zaatra.Models.ViewModels;

namespace Zaatra.Repository
{
    public class DestinationRepository : IRepository<Destination>
    {
        readonly private DatabaseContext _db = new DatabaseContext();
        public Destination Get(int id)
        {
            return _db.Destinations.Find(id);
        }

        public List<Destination> GetAll()
        {
            return _db.Destinations.ToList();
        }

        public void Add(Destination entity)
        {
            _db.Destinations.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Destination entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var destination = _db.Destinations.Find(id);
            _db.Destinations.Remove(destination);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Package> GetPackageOfSpecificDestination(int id)
        {
            var packages = _db.Packages.Where(p => p.DestinationId == id);
            return packages;
        }

        public List<PackageByDestinationViewModel> GetPackagesGroupByDestination()
        {
            var ps = (from destination in _db.Destinations
                join package in _db.Packages on destination.Id equals package.DestinationId into packages
                select new PackageByDestinationViewModel()
                {
                    DestinationId = destination.Id,
                    Packages = packages,
                    DestinationName = destination.Name
                }); 
         
            return ps.ToList();
        }

        public IQueryable<Destination> FindBy(Expression<Func<Destination, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IGrouping<bool, Destination>> FilterPlacsBy_Inside_OutSIde_Bd()
        {
            var destinations = _db.Destinations.GroupBy(p => p.IsInsideBD);
            return destinations;

        }
    }
}