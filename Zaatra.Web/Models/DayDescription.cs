using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zaatra.Models
{
    [Table("DayDescription")]
    public class DayDescription
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int DayCount { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        public virtual Package Package { get; set; }
    }
}