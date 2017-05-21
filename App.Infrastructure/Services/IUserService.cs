using App.Infrastructure.DTO;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDTO> Get(string email);
        Task Register(string email, string firstName, string lastName, string password);
    }
}
