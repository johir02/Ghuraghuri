using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("RoomType")]
    public class RoomType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; } 
    }
}