using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class HotelController : BaseController
    {
        readonly HotelService _hotelService = new HotelService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllHotels()
        {
            var hotels = _hotelService.GetHotelList();
            return Json(hotels, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id = 0)
        {
            var hotel = _hotelService.GetHotel(id);
            return View(hotel);
        }

        public ActionResult BookHotelRoom(int id = 0)
        {
            ViewBag.RoomId = id;
            return View();
        }

        [HttpPost]
        public ActionResult BookHotelRoom(HotelRoomBooking roomBooking)
        {
            if (ModelState.IsValid)
            {
                roomBooking.TimeStamp = DateTime.Now;
                _hotelService.BookHotelRoom(roomBooking);
                ViewBag.IsSuccess = "Your Hotel Room Booking requirest has been successfully sent.";
                return View();
            }
            ModelState.AddModelError("", "Please fill up the required fields.");

            return View();
        }
    }
}
