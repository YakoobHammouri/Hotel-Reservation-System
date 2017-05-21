using App.Core.Domain;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using App.Infrastructure.DTO;
using AutoMapper;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> Get(string email)
        {
            var user = await _userRepository.Get(email);

            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task Register(string email, string firstName, string lastName, string password)
        {
            var user = await _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception($"Email '{email}' is already used");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, firstName, lastName, password, salt);
            _userRepository.Add(user);
        }
    }
}
