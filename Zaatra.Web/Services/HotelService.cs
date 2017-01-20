using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class HotelService
    {
        readonly HotelRepository _hotelRepository = new HotelRepository();
        public List<HotelListViewModel> GetHotelList()
        {
            return _hotelRepository.GetHotelList();
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return _hotelRepository.GetAllRoomType();
        }

        public HotelDetailsViewModel GetHotel(int hotel)
        {
            return _hotelRepository.GetHotelDetails(hotel);
        }

        public void Add(Hotel hotel)
        {
            _hotelRepository.Add(hotel);
        }

        public void AddHotel(HotelDetailsViewModel hotelDetailsViewModel)
        {
            _hotelRepository.AddHotel(hotelDetailsViewModel);
        }

        public void BookHotelRoom(HotelRoomBooking hotelRoomBooking)
        {
            _hotelRepository.AddHotelRoomBooking(hotelRoomBooking);
        }

        public List<HotelRoomBooking> GetAllBookingRequiest()
        {
            return _hotelRepository.GetAllHotelBookingRequiest();
        }
    }
}