using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Controllers;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class DestinationService
    {
        readonly DestinationRepository _destinationRepository = new DestinationRepository();

        public List<Destination> GetAll()
        {
            return _destinationRepository.GetAll();
        } 

        public List<Package> GetPackagesOfSpecificDestination(int id)
        {
            var packages = _destinationRepository.GetPackageOfSpecificDestination(id).ToList();
            return packages;
        }

        public List<PackageByDestinationViewModel> GetPackagesGroupByDestination()
        {
            return _destinationRepository.GetPackagesGroupByDestination();
        }
        public Destination GetDestination(int id)
        {
            return _destinationRepository.Get(id);
        }

        public PlacesInsideOutsideBdViewModel FilterPlacsBy_Inside_OutSIde_Bd()
        {
            var destinationsGroupedByOrigin = _destinationRepository.FilterPlacsBy_Inside_OutSIde_Bd();
            var placesInsideOutsideBdList = new PlacesInsideOutsideBdViewModel();
            foreach (var destinations in destinationsGroupedByOrigin)
            {
                if (destinations.Key)
                {
                    placesInsideOutsideBdList.Places_InsideBd = destinations.ToList();
                }
                else
                {
                    placesInsideOutsideBdList.Places_OutsideBd = destinations.ToList();
                }
            }
            return placesInsideOutsideBdList;

        }
    }
}

