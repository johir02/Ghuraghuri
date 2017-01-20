using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("HotelService")]
    public class HotelServices
    {
        public int Id { get; set; }
        public string Parking { get; set; }
        public string Outdoors { get; set; }
        public string Activities { get; set; }
        public string Security { get; set; }
        public string Internet { get; set; }
        public string Services { get; set; }
        public string Food { get; set; }
        public string General { get; set; }
        public int HotelId { get; set; }
    }
}