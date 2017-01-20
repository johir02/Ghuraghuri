using System.Collections.Generic;
using System.Linq;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class PackageService
    {
        readonly PackageRepository _packageRepository = new PackageRepository();
        public void AddNewPackage(AddNewPackageViewModel newPackage)
        {
            var package = PreparePackageModel(newPackage);
            
            if (newPackage.DayDescriptions.Count > 0)
            {
                package.DayDescriptions = newPackage.DayDescriptions;
            }

            foreach (var packageImage in newPackage.OtherPictures.Select(picture => new PackageImage { ImageSource = picture }))
            {
                package.PackageImages.Add(packageImage);
            }
            _packageRepository.CreatePackage(package);
        }

        public Package PreparePackageModel(AddNewPackageViewModel newPackage)
        {
            var package = new Package();
            package.Name = newPackage.Name;
            package.Description = newPackage.Description;
            package.DayCount = newPackage.DayCount;
            package.NightCount = newPackage.NightCount;
            package.TourPlaces = newPackage.TourPlaces;
            package.OfferStart = newPackage.OfferStart;
            package.OfferEnd = newPackage.OfferEnd;
            package.PaymentMethod = newPackage.PaymentMethod;
            package.MinimumPerson = newPackage.MinimumPerson;
            package.AdditionalInfo = newPackage.AdditionalInfo;
            package.Hotels = newPackage.Hotels;
            package.Seasons = newPackage.Seasons;
            package.Transports = newPackage.Transports;
            package.VendorId = newPackage.VendorId;
            package.FeeExcludes = newPackage.FeeExcludes;
            package.FeeIncludes = newPackage.FeeIncludes;
            package.MonthlyInstallment = newPackage.MonthlyInstallment;
            package.TourCode = newPackage.TourCode;
            package.Price = newPackage.Price;
            package.ProfilePicSource = newPackage.ProfilePicSource;
            package.VendorId = newPackage.VendorId;
            package.DestinationId = newPackage.DestinationId;
            return package;
        }

        public IEnumerable<Package> GetAllPackage()
        {
            var packages = _packageRepository.GetAll();
            return packages;
        }

        public IEnumerable<Package> GetTwoPackages()
        {
            var packages = _packageRepository.GetAll().Take(2);
            return packages;
        }

        public Package GetPackage(int id)
        {
            return _packageRepository.Get(id);
        }

        public List<Package> GetFilteredPackages(string tags)
        {
            var taglist = tags.Split(',').ToList();
            return _packageRepository.GetFilteredPackages(taglist).ToList();
        }


        public void CreateBookPackage(PackageBooking packageBooking)
        {
            _packageRepository.AddPackageBooking(packageBooking);
        }

        public List<PackageBooking> GetAllBookingRequiest()
        {
            return _packageRepository.GetAllBookingRequiest();
        }
    }
}