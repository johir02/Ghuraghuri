using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models.ViewModels
{
    public class PackageByDestinationViewModel
    {
        public string DestinationName { get; set; }

        public int DestinationId { get; set; }

        public IEnumerable<Package> Packages { get; set; }
    }
}