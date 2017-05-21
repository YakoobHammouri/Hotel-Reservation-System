using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Domain
{
    public class Room
    {
        public int Id { get; protected set; }
        public int Capacity { get; protected set; }
        public decimal CostPerNight { get; protected set; }
        public int MaxSingleExtraBeds { get; protected set; }

        public Room(int id, int capacity, decimal costPerNight, int maxSingleExtraBeds)
        {
            Id = id;
            Capacity = capacity;
            CostPerNight = costPerNight;
            MaxSingleExtraBeds = maxSingleExtraBeds;
        }
    }
}
