using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Services;

namespace Zaatra.Controllers
{
/*
    [Authorize(Roles = "Admin")]
*/
    public class AdminController : BaseController
    {
        //
        // GET: /Admin/
        readonly PackageService _packageService = new PackageService();
        readonly VendorService _vendorService = new VendorService();
        readonly DestinationService _destinationService = new DestinationService();
        readonly HotelService _hotelService = new HotelService();
        readonly AirTicketService _airTicketService = new AirTicketService();
        public ActionResult Index()
        {
            AdminIndexModel model = new AdminIndexModel();
            model.PackageBookings = _packageService.GetAllBookingRequiest();
            model.AirTicketViewModels = _airTicketService.GetFiveTicketRequest();
            model.HotelRoomBookings = _hotelService.GetAllBookingRequiest();
            return View(model);
        }


        public ActionResult AirTicketDetails(int id=0)
        {
            AirTicketViewModel airTicketViewModel = _airTicketService.GetTicketDetailsById(id);
            return View(airTicketViewModel);
        }

        [HttpGet]
        public ActionResult AddPackage()
        {
            ViewBag.Vendors = _vendorService.GetAll();
            ViewBag.Destinations = _destinationService.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult CreatePackage(AddNewPackageViewModel newPackageViewModel, List<HttpPostedFileBase> files)
        {
            //HttpFileCollectionBase files = Request.Files;
            newPackageViewModel.OtherPictures = new List<string>();

            //HttpPostedFileBase file = Request.Files["ProfilePicture"];
            var path = SaveFileToDirectory(Request.Files["ProfilePicture"]);
            newPackageViewModel.ProfilePicSource = path;
            newPackageViewModel.OtherPictures.Add(path);

            foreach (var file in files)
            {
                path = SaveFileToDirectory(file);
                newPackageViewModel.OtherPictures.Add(path);
            }
            _packageService.AddNewPackage(newPackageViewModel);


            return RedirectToAction("Index", "Admin");
        }

        private string SaveFileToDirectory(HttpPostedFileBase file)
        {
            string path = "";
            if (file != null)
            {
                path = "/Upload/" + file.FileName;
                var filePath = Server.MapPath(path);
                file.SaveAs(filePath);
            }
            return path;
        }

        /*[HttpGet]
        public ActionResult GetImage()
        {
            return View();

        }*/

        
        public ActionResult AddVendor()
        {
            return View();
        }

        public JsonResult CreateVendor(Vendor vendor)
        {
            _vendorService.Add(vendor);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }



        public ActionResult AddVisaInformation()
        {
            ViewBag.CountryId = new SelectList(_countryService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVisaInformation(VisaInformation visainformation)
        {
            if (ModelState.IsValid)
            {
                _visaService.Add(visainformation);
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(_countryService.GetAll(), "Id", "Name", visainformation.CountryId);
            /*return View(visainformation);*/
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddHotel()
        {
            ViewBag.DestinationId = new SelectList(_destinationService.GetAll(),"Id","Name");
            ViewBag.RoomTypeId = new SelectList(_hotelService.GetAllRoomTypes(),"Id","TypeName");
            return View();
        }

        [HttpPost]
        public ActionResult AddHotel(HotelDetailsViewModel hotelDetailsViewModel, List<HttpPostedFileBase> files)
        {
            if (true)
            {
                hotelDetailsViewModel.Hotel.HotelImage = new List<HotelImage>();

                //HttpPostedFileBase file = Request.Files["ProfilePicture"];
                var path = SaveFileToDirectory(Request.Files["ProfilePicture"]);
                hotelDetailsViewModel.Hotel.ProfilePicSource = path;
                hotelDetailsViewModel.Hotel.HotelImage.Add(new HotelImage
                {
                    ImageSource = path
                });

                foreach (var file in files)
                {
                    path = SaveFileToDirectory(file);
                    hotelDetailsViewModel.Hotel.HotelImage.Add(new HotelImage
                    {
                        ImageSource = path
                    });
                }
                
                _hotelService.AddHotel(hotelDetailsViewModel);
            }
            ViewBag.DestinationId = new SelectList(_destinationService.GetAll(), "Id", "Name");
            ViewBag.RoomTypeId = new SelectList(_hotelService.GetAllRoomTypes(), "Id", "TypeName");
            /*return View();*/
            return RedirectToAction("Index", "Home");
        }


    }

}

