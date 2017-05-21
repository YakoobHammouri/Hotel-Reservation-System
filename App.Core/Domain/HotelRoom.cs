using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Domain
{
    public class HotelRoom
    {
        public Room Room { get; protected set; }
        public bool IsAvaiable { get; protected set; }

        public HotelRoom(Room room)
        {
            Room = room;
            IsAvaiable = true;
        }

        public void Booked()
        {
            IsAvaiable = false;
        }
    }
}
