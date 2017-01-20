using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Zaatra.Models.Enum;

namespace Zaatra.Models
{
    [Table("AirTicket")]
    public class AirTicket
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string StartingPoint { get; set; }
        public string Destination { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [Required]
        public string DateType { get; set; }
        [Required][Range(1,100)]
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }
        [Required]
        public string CabinClass { get; set; }

        public DateTime RequestTime { get; set; }

        public virtual ICollection<TicketPersonalInfo> TicketPersonalInfos { get; set; }
    }
}