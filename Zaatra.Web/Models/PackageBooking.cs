using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PackageBooking")]
    public class PackageBooking
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Person number is required.")]
        public int NumberOfPerson { get; set; }
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }
        public string SpecialRequirements { get; set; }
        public int PackageId { get; set; }
        public DateTime TimeStamp { get; set; }


        public virtual Package Package { get; set; }
    }
}