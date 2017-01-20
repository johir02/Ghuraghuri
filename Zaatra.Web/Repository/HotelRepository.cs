using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Zaatra.Models;
using Zaatra.Models.ViewModels;

namespace Zaatra.Repository
{
    public class HotelRepository:IRepository<Hotel>
    {
        private DatabaseContext _db = new DatabaseContext();
        public HotelDetailsViewModel GetHotelDetails(int id)
        {
            var detailedHotels = new HotelDetailsViewModel
            {
                Hotel = _db.Hotels.Include("HotelImage").FirstOrDefault(_=>_.Id==id),
                HotelPolicy = _db.HotelPolicies.FirstOrDefault(_ => _.HotelId == id),
                HotelService = _db.HotelServices.FirstOrDefault(_ => _.HotelId == id),
                Rooms = _db.Rooms.Where(_ => _.HotelId == id).Include("RoomType").ToList()
            };
            return detailedHotels;
        }

        public Hotel Get(int id)
        {
            return _db.Hotels.Find(id);
        }

        public List<Hotel> GetAll()
        {
            return _db.Hotels.ToList();
        }

        public List<HotelListViewModel> GetHotelList()
        {
            var hotels = (from hotel in _db.Hotels
                          let discount = _db.Rooms.Where(_ => _.HotelId==hotel.Id).Max(_=>_.Discount)
                select new HotelListViewModel
                {
                    Name = hotel.Name,
                    Destination = hotel.Destination.Name,
                    Address = hotel.Address,
                    Id = hotel.Id,
                    Discount = discount,
                    Price = _db.Rooms.Where(_ => _.HotelId==hotel.Id).Min(_=>_.Price),
                    RoomType = _db.Rooms.FirstOrDefault(_=>_.HotelId==hotel.Id && Math.Abs(_.Discount - discount) < 1).RoomType.TypeName,
                    Occupancy = _db.Rooms.FirstOrDefault(_ => _.HotelId == hotel.Id && Math.Abs(_.Discount - discount) < 1).MaximumOccupancy,
                    ProPic = hotel.ProfilePicSource
        }).ToList();

            return hotels;
        }

        public void Add(Hotel entity)
        {
            _db.Hotels.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var hotel = _db.Hotels.Find(id);
            _db.Hotels.Remove(hotel);
            _db.SaveChanges();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IQueryable<Hotel> FindBy(Expression<Func<Hotel, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        internal void AddHotel(HotelDetailsViewModel hotelDetailsViewModel)
        {
            _db.Hotels.Add(hotelDetailsViewModel.Hotel);
            _db.SaveChanges();

            /*foreach (var image in hotelDetailsViewModel.Hotel.HotelImage)
            {
                image.HotelId = hotelDetailsViewModel.Hotel.Id;
                _db.HotelImages.Add(image);
            }*/
            _db.SaveChanges();

            var hotelId = hotelDetailsViewModel.Hotel.Id;

            hotelDetailsViewModel.HotelService.HotelId = hotelId;
            _db.HotelServices.Add(hotelDetailsViewModel.HotelService);

            hotelDetailsViewModel.HotelPolicy.HotelId = hotelId;
            _db.HotelPolicies.Add(hotelDetailsViewModel.HotelPolicy);

            foreach (var rooms in hotelDetailsViewModel.Rooms)
            {
                rooms.HotelId = hotelId;
                _db.Rooms.Add(rooms);
            }

            _db.SaveChanges();
        }

        internal List<RoomType> GetAllRoomType()
        {
            return _db.RoomTypes.ToList();
        }

        public void AddHotelRoomBooking(HotelRoomBooking booking)
        {
            _db.HotelRoomBookings.Add(booking);
            _db.SaveChanges();
        }

        public List<HotelRoomBooking> GetAllHotelBookingRequiest()
        {
            return _db.HotelRoomBookings.Include("Room.Hotel").ToList();
        }
    }
}