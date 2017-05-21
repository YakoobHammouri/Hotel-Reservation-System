using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Domain;
using App.Infrastructure.DTO;
using App.Core.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IHotelRoomsRepository _hotelRoomsRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IHotelRoomsRepository hotelRoomsRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _hotelRoomsRepository = hotelRoomsRepository;
            _mapper = mapper;
        }

        public async Task Add(Guid clientId, int roomId, DateTime checkinDate, DateTime checkoutDate, int adults = 1,
                            int children = 0, bool breakfastIncluded = false, bool highteaIncluded = false, int extraSingleBeds = 0)
        {
            var room = _hotelRoomsRepository.Get(roomId).Result.Room;

            await _hotelRoomsRepository.Reserve(room.Id);

            var reservation = new Reservation(
                clientId,
                roomId,
                checkinDate,
                checkoutDate,
                adults,
                children,
                breakfastIncluded,
                highteaIncluded,
                extraSingleBeds
                );
             await _reservationRepository.Add(reservation);

            var breakfastPrice = 10;
            var highteaPrice = 25;
            var singleBedPrice = 20;

            var days = (reservation.CheckOutDate - reservation.CheckInDate).Days;

            var breakfastTotalPrice = reservation.BreakfastIncluded ? breakfastPrice * days * (reservation.Adults + reservation.Children) : 0;
            var highteaTotalPrice = reservation.HighteaIncluded ? highteaPrice * days * (reservation.Adults + reservation.Children) : 0;
            var singleBedTotalPrice = singleBedPrice * reservation.ExtraSingleBeds * days;
            var totalCost = days * room.CostPerNight + breakfastTotalPrice +
                               highteaTotalPrice + singleBedTotalPrice;

            reservation.SetCost(totalCost);
        }

        public async Task<ISet<ReservationDTO>> GetAll()
        {
            ISet<ReservationDTO> reservationsDTO = new HashSet<ReservationDTO>();
            foreach (Reservation reservation in await _reservationRepository.GetAll())
            {
                reservationsDTO.Add(
                    _mapper.Map<Reservation, ReservationDTO>(reservation)
                    );
            }

            return reservationsDTO;
        }
    }
}
