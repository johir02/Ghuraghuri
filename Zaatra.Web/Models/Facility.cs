using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("Facility")]
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}