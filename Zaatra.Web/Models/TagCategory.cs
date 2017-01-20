﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("TagCategory")]
    public class TagCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
