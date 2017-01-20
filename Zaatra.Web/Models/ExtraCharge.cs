using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("ExtraCharge")]
    public class ExtraCharge
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string Place { get; set; }
        public string Hotel { get; set; }
        public int AdultCost { get; set; }
        public int ChildrenCost { get; set; }
        public int ChargeTypeId { get; set; }
    }
}