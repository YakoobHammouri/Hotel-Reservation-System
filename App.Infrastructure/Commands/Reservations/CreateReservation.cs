using App.Core.Domain;
using App.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.Commands.Reservations
{
    public class CreateReservation : ICommand
    {
        public Guid ClientId { get; set; }
        public int Id { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool HighteaIncluded { get; set; }
        public int ExtraSingleBeds { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
