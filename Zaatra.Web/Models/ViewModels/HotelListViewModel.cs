using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models.ViewModels
{
    public class HotelListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Destination { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string RoomType { get; set; }
        public int? Occupancy { get; set; }
        public string ProPic { get; set; }
    }
}