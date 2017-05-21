using App.Core.Domain;
using App.Infrastructure.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
                => new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<User, UserDTO>();
                    cfg.CreateMap<HotelRoom, HotelRoomDTO>();
                    cfg.CreateMap<Room, RoomDTO>();
                    cfg.CreateMap<Reservation, ReservationDTO>();
                })
            .CreateMapper();
    }
}
