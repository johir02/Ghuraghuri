using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zaatra.Models
{
    [Table("VisaInformation")]
    public class VisaInformation
    {
        public int Id { get; set; }

        [AllowHtml]
        public string Requirement { get; set; }
        public double VisaFee { get; set; }
        public string OnlineApplicationLink { get; set; }
        public string Note { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}