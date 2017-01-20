using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zaatra.Models
{
    [Table("PolicyCondition")]
    public class PolicyCondition
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string Condition { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual ICollection<PackagePolicy> PackagePolicies { get; set; }

    }
}