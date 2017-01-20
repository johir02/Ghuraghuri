using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class HomeController : BaseController
    {
        readonly PackageService _packageService = new PackageService();
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var packages = _packageService.GetTwoPackages();
            return View(packages);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
