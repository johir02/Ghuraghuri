using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class TicketController : BaseController
    {
        readonly AirTicketService _airTicketService = new AirTicketService();
        //
        // GET: /Ticket/
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AirTicketViewModel airTicketViewModel)
        {
            /*if (ModelState.IsValid)
            {
                _airTicketService.AddAirTicketRequiest(airTicketViewModel);
            }*/
            airTicketViewModel.AirTicket.RequestTime = DateTime.Now;
            _airTicketService.AddAirTicketRequiest(airTicketViewModel);
            return View();
        }
        
    }
}
