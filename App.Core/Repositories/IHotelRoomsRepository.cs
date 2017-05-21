using App.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
    public interface IHotelRoomsRepository
    {
        Task Add(Room room);
        Task Add(Room room, int amount);
        Task Reserve(int id);
        Task<List<HotelRoom>> GetAll();
        Task<HotelRoom> Get(int roomId);
    }
}
