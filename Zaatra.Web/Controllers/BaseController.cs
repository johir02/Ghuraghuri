using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class BaseController : Controller
    {
        private PackageService _packageService;
        private PackageTagService _packageTagService;
        private DestinationService _destinationService;
        private TagService _tagService;
        private VendorService _vendorService;
        protected readonly VisaService _visaService ;
        protected CountryService _countryService;

        public BaseController()
        {
            _packageService = new PackageService();
            _packageTagService = new PackageTagService();
            _destinationService = new DestinationService();
            _tagService = new TagService();
            _vendorService = new VendorService();
            _visaService = new VisaService();
            _countryService = new CountryService();

            ViewBag.Destinations = _destinationService.FilterPlacsBy_Inside_OutSIde_Bd();
        }
    }
}