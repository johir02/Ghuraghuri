using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackageImage")]
    public class PackageImage
    {
        public int Id { get; set; }
        public string ImageSource { get; set; }
        public int PackageId { get; set; }

        public Package Package { get; set; }


    }
}