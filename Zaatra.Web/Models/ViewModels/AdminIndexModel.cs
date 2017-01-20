using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models.ViewModels
{
    public class AdminIndexModel
    {
        public List<PackageBooking> PackageBookings { get; set; }

        public List<AirTicketViewModel> AirTicketViewModels { get; set; }
        
        public List<HotelRoomBooking> HotelRoomBookings { get; set; }
    }
}