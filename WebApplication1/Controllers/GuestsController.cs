using App.Infrastructure.Commands.Users;
using App.Infrastructure.DTO;
using App.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("[controller]")]
    public class GuestsController : Controller
    {
        private readonly IUserService _userService;

        public GuestsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public async Task<UserDTO> Get(string email)
            => await _userService.Get(email);

        [HttpPost]
        public async Task Post([FromBody]CreateUser request)
        {
            await _userService.Register(request.Email, request.FirstName, request.LastName, request.Password);
        }
    }
}
