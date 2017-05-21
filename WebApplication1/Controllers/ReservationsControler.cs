using App.Infrastructure.Commands.Reservations;
using App.Infrastructure.DTO;
using App.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("[controller]")]
    public class ReservationsController : Controller
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService= reservationService;
        }

        [HttpGet]
        public async Task<ISet<ReservationDTO>> Get()
            => await _reservationService.GetAll();

        [HttpPost]
        public async Task Post([FromBody]CreateReservation request)
        {
            await _reservationService.Add(request.ClientId, request.Id, request.CheckInDate, request.CheckOutDate, request.Adults, request.Children, request.BreakfastIncluded, request.HighteaIncluded, request.ExtraSingleBeds);
        }
    }
}
