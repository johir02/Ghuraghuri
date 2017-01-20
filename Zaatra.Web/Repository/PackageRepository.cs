using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using System.Data.Entity;
using Type = Zaatra.Models.Type;

namespace Zaatra.Repository
{
    public class PackageRepository : IRepository<Package>
    {
        readonly private DatabaseContext _db = new DatabaseContext();

        public int CreatePackage(Package package)
        {
            _db.Packages.Add(package);
            _db.SaveChanges();
            return package.Id;
        }
        public int CreatePackageType(Type packageType)
        {
            _db.Types.Add(packageType);
            _db.SaveChanges();
            return packageType.Id;
        }

        public int CreateDestination(Destination destionation)
        {
            _db.Destinations.Add(destionation);
            _db.SaveChanges();
            return destionation.Id;
        }


        public int CreatePackageIncludes(PackageIncludes packageIncludes)
        {
            _db.PackageIncludeses.Add(packageIncludes);
            _db.SaveChanges();
            return packageIncludes.Id;
        }

        public int CreatePackageCondition(PolicyCondition packageCondition)
        {
            _db.PackageConditions.Add(packageCondition);
            _db.SaveChanges();
            return packageCondition.Id;
        }

        public int CreatePolicy(Policy policy)
        {
            _db.Policies.Add(policy);
            _db.SaveChanges();
            return policy.Id;
        }

        public int CreateVendor(Vendor vendor)
        {
            _db.Vendors.Add(vendor);
            _db.SaveChanges();
            return vendor.Id;
        }

        public int CreateExtraCharge(ExtraCharge extraCharge)
        {
            _db.ExtraCharges.Add(extraCharge);
            _db.SaveChanges();
            return extraCharge.Id;
        }

        public int CreateChargeType(ChargeType chargeType)
        {
            _db.ChargeTypes.Add(chargeType);
            _db.SaveChanges();
            return chargeType.Id;
        }

        public int CreateDayDescription(DayDescription dayDescription)
        {
            _db.DayDescriptions.Add(dayDescription);
            _db.SaveChanges();
            return dayDescription.Id;
        }

        public int CreateTag(Tag tag)
        {
            _db.Tags.Add(tag);
            _db.SaveChanges();
            return tag.Id;
        }

        public int CreatePackageTag(PackageTag packageTag)
        {
            _db.PackageTags.Add(packageTag);
            _db.SaveChanges();
            return packageTag.Id;
        }

        public int CreatePackageImage(PackageImage packageImage)
        {
            _db.PackageImages.Add(packageImage);
            _db.SaveChanges();
            return packageImage.Id;
        }

        public int CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user.Id;
        }

        public int CreateRoles(Roles roles)
        {
            _db.Roleses.Add(roles);
            _db.SaveChanges();
            return roles.Id;
        }

        public int CreateUserRole(UserRole userRole)
        {
            _db.UserRoles.Add(userRole);
            _db.SaveChanges();
            return userRole.Id;
        }

        public IQueryable<Package> GetQuery()
        {
            var package = _db.Packages.Include(p => p.DayDescriptions)
                .Include(p => p.Vendor)
                .Include(p => p.PackagePolicies.Select(pt => pt.PolicyCondition.Policy))
                .Include(p => p.PackageTypes.Select(pt => pt.Type))
                .Include(p => p.PackageTags.Select(pt => pt.Tag)).Include(p => p.PackageImages);
            return package;
        } 

        public Package Get(int id)
        {
            var package = _db.Packages.Include(p => p.DayDescriptions)
                .Include(p=>p.Vendor)
                .Include(p => p.PackagePolicies.Select(pt=>pt.PolicyCondition.Policy))
                .Include(p => p.PackageTypes.Select(pt => pt.Type))
                .Include(p => p.PackageTags.Select(pt => pt.Tag)).Include(p=>p.PackageImages);


            return package.FirstOrDefault(p => p.Id == id);
        }

        public List<Package> GetAll()
        {
            return _db.Packages.ToList();
        }

        public void Add(Package entity)
        {
            _db.Packages.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Package entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            //var package = _db.Packages.Find(id);
            var package = _db.Packages.Include(p => p.DayDescriptions).FirstOrDefault(p => p.Id == id);
            _db.Packages.Remove(package);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Package> FindBy(Expression<Func<Package, bool>> predicate)
        {
             
            IQueryable<Package> query = _db.Set<Package>().Where(predicate);
            return query;
        }

        public IQueryable<Package> GetFilteredPackages(List<string> tags)
        {
            var packages = (from p in _db.Packages
                join pt in _db.PackageTags on p.Id equals pt.PackageId
                join t in _db.Tags on pt.TagId equals t.Id
                where tags.Contains(t.Name)
                select p).Distinct();

            return packages;
        }

        public void AddPackageBooking(PackageBooking booking)
        {
            _db.PackageBookings.Add(booking);
            _db.SaveChanges();
        }

        public List<PackageBooking> GetAllBookingRequiest()
        {
            return _db.PackageBookings.Include("Package").ToList();
        }
    }
}