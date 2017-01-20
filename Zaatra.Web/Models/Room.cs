using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("Room")]
    public class Room
    {
        public int Id { get; set; }
        public int MaximumOccupancy { get; set; }
        public bool Breakfast { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }
        /*public string Picture { get; set; } */
        
        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<HotelRoomBooking> HotelRoomBookings { get; set; }
    }
}