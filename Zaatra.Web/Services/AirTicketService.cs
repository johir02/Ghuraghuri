using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Repository;
using TicketPersonalInfo = Zaatra.Repository.TicketPersonalRepository;

namespace Zaatra.Services
{
    public class AirTicketService
    {
        readonly AirTicketRepository _airTicketRepository = new AirTicketRepository();
        readonly TicketPersonalRepository _ticketPersonalRepository = new TicketPersonalRepository();
        
        public void AddAirTicketRequiest(AirTicketViewModel airTicket)
        {
            int airTicketId = _airTicketRepository.Add(airTicket.AirTicket);
            airTicket.TicketPersonalInfo.AirTicketId = airTicketId;
            _ticketPersonalRepository.Add(airTicket.TicketPersonalInfo);
        }

        public List<AirTicketViewModel> GetFiveTicketRequest()
        {
            var airTicketViewModels = new List<AirTicketViewModel>();
            var airTickets = _airTicketRepository.GetAll();
            foreach (var airTicket in airTickets)
            {
                airTicketViewModels.Add(new AirTicketViewModel
                {
                    AirTicket = airTicket,
                    TicketPersonalInfo = _ticketPersonalRepository.GetByTicketId(airTicket.Id)
                });
            }
            return airTicketViewModels.Take(5).ToList();
        }

        public AirTicketViewModel GetTicketDetailsById(int id=0)
        {
            AirTicketViewModel airTicketViewModel = new AirTicketViewModel();

            airTicketViewModel.AirTicket = _airTicketRepository.Get(id);
            airTicketViewModel.TicketPersonalInfo = _ticketPersonalRepository.GetByTicketId(id);
            return airTicketViewModel;
        }
    }
}