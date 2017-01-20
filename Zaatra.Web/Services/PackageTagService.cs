using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class PackageTagService
    {
        readonly PackageTagRepository _packageTagRepository = new PackageTagRepository();
        public List<PackageTag> GetAll()
        {
            return _packageTagRepository.GetAll();
        } 

    }
}