using App.Core.Domain;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class FakeHotelRoomsRepository : IHotelRoomsRepository
    {
        private static List<HotelRoom> _rooms = new List<HotelRoom>
        {
            new HotelRoom(new Room(1, 2, 50, 0)), new HotelRoom(new Room(2, 2, 50, 0)), new HotelRoom(new Room(3, 2, 80, 1)), new HotelRoom(new Room(4, 2, 80, 1)),
            new HotelRoom(new Room(5, 2, 80, 1)), new HotelRoom(new Room(6, 3, 120, 0)), new HotelRoom(new Room(7, 3, 120, 0)), new HotelRoom(new Room(8, 3, 140, 1)),
            new HotelRoom(new Room(9, 3, 140, 1)), new HotelRoom(new Room(10, 3, 200, 2)), new HotelRoom(new Room(11, 3, 200, 3)), new HotelRoom(new Room(12, 9, 400, 0))
        };

        public async Task Add(Room room)
        {
            _rooms.Add(new HotelRoom(room));
        }

        public async Task Add(Room room, int amount)
        {
            for (int i = 0; i < amount; i++)
                _rooms.Add(new HotelRoom(room));
        }

        public async Task<HotelRoom> Get(int roomId)
            => _rooms.SingleOrDefault(x => x.Room.Id == roomId);

        public async Task<List<HotelRoom>> GetAll()
            => _rooms;

        public async Task Reserve(int id)
        {
            var room = _rooms.FirstOrDefault(x => x.IsAvaiable && x.Room.Id == id);
            if (room==null)
            {
                throw new Exception("There are not any avaiable rooms");
            }
            room.Booked();
        }

        
    }
}
