using App.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> Get(string email);
        Task<User> Get(Guid id);
        Task<IEnumerable<User>> GetAll();
        Task Add(User user);
        Task Update(User user);
        Task Delete(Guid id);
    }
}
