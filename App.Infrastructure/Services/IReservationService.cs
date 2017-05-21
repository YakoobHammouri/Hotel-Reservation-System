using App.Core.Domain;
using App.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public interface IReservationService
    {
        Task<ISet<ReservationDTO>> GetAll();
        Task Add(Guid clientId, int roomId, DateTime checkinDate, DateTime checkoutDate, int adults = 1,
                            int children = 0, bool breakfastIncluded = false, bool highteaIncluded = false, int extraSingleBeds = 0);
    }
}
