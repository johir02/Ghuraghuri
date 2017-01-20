using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("Roles")]
    public class Roles
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}