using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public decimal CostPerNight { get; set; }
    }
}
