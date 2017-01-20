using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackageCondition")]
    public class PackagePolicy
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string Condition { get; set; }

        public virtual Policy Policy { get; set; }
    }
}