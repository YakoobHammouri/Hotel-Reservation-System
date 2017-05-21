using App.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public interface IHotelRoomsService
    {
        Task<List<HotelRoomDTO>> GetAll();
    }
}
