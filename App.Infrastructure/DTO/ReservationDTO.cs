using App.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.DTO
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public int RoomId { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool HighteaIncluded { get; set; }
        public int ExtraSingleBeds { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalCost { get; set; }
    }
}
