using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    public class PackageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TourPlaces { get; set; }
        public int DayCount { get; set; }
        public int NightCount { get; set; }
        public string Description { get; set; }
        public string TourCode { get; set; }
        public string OfferDuration { get; set; }
        public string Transports { get; set; }
        public string MonthlyInstallment { get; set; }
        public string PaymentMethod { get; set; }
        public string MinimumPerson { get; set; }
        public int VendorId { get; set; }
        public int TypeId { get; set; }

        public List<PackageIncludes> PackageIncludeses { get; set; }
        public List<PolicyCondition> PackageConditions { get; set; }
        public List<Policy> Policies { get; set; }
        public List<ExtraCharge> ExtraCharges { get; set; }
        public List<DayDescription> DayDescriptions { get; set; }
        public List<Tag> Tags { get; set; }
        public List<PackageImage> PackageImages { get; set; } 
    }
}