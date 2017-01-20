using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("HotelPolicy")]
    public class HotelPolicy
    {
        public int Id { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Payment { get; set; }
        public string Pets { get; set; }
        public string Children { get; set; }
        public int HotelId { get; set; }
    }
}