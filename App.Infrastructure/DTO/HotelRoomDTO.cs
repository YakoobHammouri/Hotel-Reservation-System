using App.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.DTO
{
    public class HotelRoomDTO
    {
        public RoomDTO Room { get; set; }
        public bool IsAvaiable { get; set; }
    }
}
