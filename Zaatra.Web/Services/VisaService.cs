using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class VisaService
    {
        readonly VisaInformationRepository _visaInformationRepository = new VisaInformationRepository();
        readonly CountryRepository _countryRepository = new CountryRepository();

        public VisaInformation GetByCountry(int countryId)
        {
            return _visaInformationRepository.GetByCountry(countryId);
        }

        public List<Country> GetAllCountry()
        {
            return _countryRepository.GetAll();
        }

        public void Add(VisaInformation visaInformation)
        {
             _visaInformationRepository.Add(visaInformation);
        }
    }
}