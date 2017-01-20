using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("Tag")]
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TagCategoryId { get; set; }

        public TagCategory TagCategory { get; set; }
        public virtual ICollection<PackageTag> PackageTags { get; set; }

    }
}