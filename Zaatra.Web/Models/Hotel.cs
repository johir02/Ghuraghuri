using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int DestinationId { get; set; }
        public string ProfilePicSource { get; set; }

        public virtual ICollection<HotelImage> HotelImage { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public  virtual Destination Destination { get; set; }
    }
}