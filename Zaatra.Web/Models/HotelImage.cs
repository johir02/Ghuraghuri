using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Zaatra.Models
{
    [Table("HotelImage")]
    public class HotelImage
    {
        public int Id { get; set; }
        public string ImageSource { get; set; }
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }
    }
}