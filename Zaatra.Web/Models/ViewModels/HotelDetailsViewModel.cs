using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models.ViewModels
{
    public class HotelDetailsViewModel
    {
        public Hotel Hotel { get; set; }
        public List<Room> Rooms { get; set; }
        public HotelServices HotelService { get; set; }
        public HotelPolicy HotelPolicy { get; set; }
    }
}