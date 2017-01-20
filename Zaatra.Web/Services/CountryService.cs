using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class CountryService
    {
        readonly CountryRepository _countryRepository = new CountryRepository();
        public List<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }
    }
}