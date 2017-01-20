using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class VendorService
    {
        readonly VendorRepository _vendorRepository = new VendorRepository();
        public List<Vendor> GetAll()
        {
            return _vendorRepository.GetAll();
        }

        public void Add(Vendor vendor)
        {
            _vendorRepository.Add(vendor);
        }
    }
}