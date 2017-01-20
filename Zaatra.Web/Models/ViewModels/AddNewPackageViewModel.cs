using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Zaatra.Models.ViewModels
{
    public class AddNewPackageViewModel
    {
        public AddNewPackageViewModel()
        {
            OtherPictures = new List<string>();
        }
        public string Name { get; set; }
        public string TourPlaces { get; set; }
        public int DayCount { get; set; }
        public int NightCount { get; set; }
        public string Description { get; set; }
        public string TourCode { get; set; }
        public double Price { get; set; }
        public DateTime OfferStart { get; set; }
        public DateTime OfferEnd { get; set; }

        public string MonthlyInstallment { get; set; }
        public string PaymentMethod { get; set; }
        public string MinimumPerson { get; set; }
        public string ProfilePicSource { get; set; }
        
        [AllowHtml]
        public string AdditionalInfo { get; set; }
        public string Transports { get; set; }
        //public string VisaInformation { get; set; }
        public string Hotels { get; set; }
        public string Seasons { get; set; }

        [AllowHtml]
        public string FeeIncludes { get; set; }

        [AllowHtml]
        public string FeeExcludes { get; set; }

        public int VendorId { get; set; }
        public int TypeId { get; set; }
        public int DestinationId { get; set; }
        public List<DayDescription> DayDescriptions { get; set; }

        public List<string> OtherPictures { get; set; }
    }
}