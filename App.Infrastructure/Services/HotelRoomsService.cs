using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using App.Infrastructure.DTO;
using App.Core.Repositories;
using AutoMapper;
using App.Core.Domain;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class HotelRoomsService : IHotelRoomsService
    {
        private readonly IHotelRoomsRepository _hotelRoomsRepository;
        private readonly IMapper _mapper;

        public HotelRoomsService(IHotelRoomsRepository hotelRoomsRepository, IMapper mapper)
        {
            _hotelRoomsRepository = hotelRoomsRepository;
            _mapper = mapper;
        }

        public async Task<List<HotelRoomDTO>> GetAll()
        {
            List<HotelRoomDTO> hotelRoomsDTO = new List<HotelRoomDTO>();
            foreach (HotelRoom room in await _hotelRoomsRepository.GetAll())
            {
                hotelRoomsDTO.Add(
                    _mapper.Map<HotelRoom, HotelRoomDTO>(room)
            );
            }
            return hotelRoomsDTO;
        }
    }
}
