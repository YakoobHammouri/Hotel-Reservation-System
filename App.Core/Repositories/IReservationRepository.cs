using App.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
    public interface IReservationRepository
    {
        Task<Reservation> Get(Guid id);
        Task<IEnumerable<Reservation>> GetAll();
        Task Add(Reservation reservation);
        Task Cancell(Guid id);
    }
}
