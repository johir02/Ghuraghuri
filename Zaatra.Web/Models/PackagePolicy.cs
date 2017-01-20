using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackagePolicy")]
    public class PackagePolicy
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int PolicyConditionId { get; set; }

        public Package Package { get; set; }
        public PolicyCondition PolicyCondition { get; set; }
    }
}