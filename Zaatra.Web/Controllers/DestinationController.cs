using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class DestinationController : BaseController
    {
        readonly DestinationService _destinationService = new DestinationService();
        //
        // GET: /Destination/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllDestinations()
        {
            var destinations = _destinationService.GetAll();
            return Json(destinations, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPackagesOfSpecificDestination()
        {
            var destinations = _destinationService.GetAll();
            return Json(destinations, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPackagesGroupByDestination()
        {
            var packages = _destinationService.GetPackagesGroupByDestination();
            return Json(packages, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetFilteredDestination()
        {
            return Json(_destinationService.FilterPlacsBy_Inside_OutSIde_Bd(),JsonRequestBehavior.AllowGet);
        }
    }
}
