using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("HotelRoomBooking")]
    public class HotelRoomBooking
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Number of Rooms is required.")]
        public int NumberOfRooms { get; set; }
        [Required(ErrorMessage = "CheckIn date is required.")]
        public DateTime CheckInDate { get; set; }
        [Required(ErrorMessage = "CheckOut date is required.")]
        public DateTime CheckOutDate { get; set; }
        public int RoomId { get; set; }
        public DateTime TimeStamp { get; set; }

/*
        [ForeignKey("RoomId")]
*/
        public virtual Room Room { get; set; }
    }
}