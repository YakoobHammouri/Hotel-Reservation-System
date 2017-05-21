using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class FakeReservationRepository : IReservationRepository
    {
        private static ISet<Reservation> _reservations = new HashSet<Reservation>
        {
            new Reservation(
                Guid.NewGuid(),
                1,
                DateTime.Now,
                DateTime.Now.AddDays(3),
                5, 1, false, true, 1
                )
        };

        public async Task Add(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public async Task Cancell(Guid id)
        {
            var reservation = await Get(id);
            _reservations.Remove(reservation);
        }

        public async Task<Reservation> Get(Guid id)
            => _reservations.SingleOrDefault(x => x.Id == id);

        public async Task<IEnumerable<Reservation>> GetAll()
            => _reservations;
    }
}
