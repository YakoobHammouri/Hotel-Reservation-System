using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Domain
{
    public class Reservation
    {
        public Guid Id { get; protected set; }
        public Guid ClientId { get; protected set; }
        public int RoomId { get; protected set; }
        public int Adults { get; protected set; }
        public int Children { get; protected set; }
        public bool BreakfastIncluded { get; protected set; }
        public bool HighteaIncluded { get; protected set; }
        public int ExtraSingleBeds { get; protected set; }
        public DateTime CheckInDate { get; protected set; }
        public DateTime CheckOutDate { get; protected set; }
        public decimal TotalCost { get; protected set; }

        public Reservation (Guid clientId, int roomId, DateTime checkinDate, DateTime checkoutDate, int adults = 1, 
                            int children = 0, bool breakfastIncluded = false, bool highteaIncluded = false, int extraSingleBeds = 0)
        {
            Id = Guid.NewGuid();
            ClientId = clientId;
            RoomId = roomId;
            Adults = adults;
            Children = children;
            BreakfastIncluded = breakfastIncluded;
            HighteaIncluded = highteaIncluded;
            ExtraSingleBeds = extraSingleBeds;
            CheckInDate = checkinDate;
            CheckOutDate = checkoutDate;
        }

        public void SetCost(decimal cost)
        {
            TotalCost = cost;
        }
    }
}
