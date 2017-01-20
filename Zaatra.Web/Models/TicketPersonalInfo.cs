using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("TicketPersonalInfo")]
    public class TicketPersonalInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string AirLinePreference { get; set; }
        public double Budget { get; set; }
        public string MembershipCode { get; set; }
        public int AirTicketId { get; set; }

        [ForeignKey("AirTicketId")]
        public virtual AirTicket AirTicket { get; set; }
    }
}