using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("RoomFacilityRelation")]
    public class RoomFacilityRelation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int FacilityId { get; set; }

    }
}