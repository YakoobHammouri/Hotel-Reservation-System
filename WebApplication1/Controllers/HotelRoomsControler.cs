using App.Infrastructure.DTO;
using App.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("[controller]")]
    public class HotelRoomsController : Controller
    {
        private readonly IHotelRoomsService _hotelRoomsService;

        public HotelRoomsController(IHotelRoomsService hotelRoomsService)
        {
            _hotelRoomsService = hotelRoomsService;
        }

        [HttpGet]
        public async Task<List<HotelRoomDTO>> Get()
            => await _hotelRoomsService.GetAll();

    }
}
