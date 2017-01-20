using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Zaatra.Models;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class VisaController : BaseController
    {
        //
        // GET: /Visa/

        public ActionResult Index()
        {
            var country = _visaService.GetAllCountry();
            return View(country);
        }

        public ActionResult VisaDetails(int id = 0)
        {
            var info = _visaService.GetByCountry(id);
            return View(info);
        }

        /*public ActionResult GetVisaByContryId(int id = 0)
        {
            var info = _visaService.GetByCountry(id);
            return View(info);
        }*/

        
    }
}
