using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Zaatra.Models;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class PackageController : BaseController
    {
        readonly PackageService _packageService = new PackageService();
        readonly TagService _tagService = new TagService();
        readonly PackageTagService _packageTagService = new PackageTagService();

        public ActionResult Index()
        {
            ViewBag.tags = _tagService.GetTagsForFilterPortion();
            var packages = _packageService.GetAllPackage();
            return View((List<Package>) packages);
        }

        public ActionResult GetAllPackage()
        {
            var packages = _packageService.GetAllPackage();
            return Json(packages, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Details(int id = 0)
        {
            var package = _packageService.GetPackage(id);
            return View(package);
        }


        [HttpGet]
        public ActionResult CreatePackageType()
        {
            return View();
        }

        public ActionResult GetFilteredPackage(string searchString)
        {
            var packages = _packageService.GetFilteredPackages(searchString);
            return Json(packages, JsonRequestBehavior.AllowGet);
        }

        public ActionResult BookPackage(int id = 0)
        {
            ViewBag.PackageId = id;
            return View();
        }

        [HttpPost]
        public ActionResult BookPackage(PackageBooking packageBooking)
        {
            if (ModelState.IsValid)
            {
                packageBooking.TimeStamp = DateTime.Now;
                _packageService.CreateBookPackage(packageBooking);
                ViewBag.IsSuccess = "Your Package Booking requirest has been successfully sent.";
                return View();
            }
            ModelState.AddModelError("", "Please fill up the required fields.");

            return View();
        }
    }
}
