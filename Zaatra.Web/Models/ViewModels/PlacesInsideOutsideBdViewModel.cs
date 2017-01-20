using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;

namespace Zaatra.Controllers
{
    public class PlacesInsideOutsideBdViewModel
    {
        public List<Destination> Places_InsideBd { get; set; }
        public List<Destination> Places_OutsideBd { get; set; }
    }
}