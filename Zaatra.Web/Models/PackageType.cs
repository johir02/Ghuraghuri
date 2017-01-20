using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackageType")]
    public class PackageType
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int PackageId { get; set; }

        public Type Type { get; set; }
        public Package Package { get; set; }
    }
}