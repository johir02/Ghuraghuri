using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackageIncludes")]
    public class PackageIncludes
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string Description { get; set; }
    }
}