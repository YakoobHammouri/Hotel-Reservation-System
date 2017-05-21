using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Domain;
using App.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("email1@com.pl", "Jan", "Kowalski", "secret", "salt"),
            new User("email2@com.pl", "Jan", "Kowalski", "secret", "salt"),
            new User("email3@com.pl", "Jan", "Kowalski", "secret", "salt")
        };

        public async Task Add(User user)
        {
            _users.Add(user);
        }

        public async Task Delete(Guid id)
        {
            var user = await Get(id);
            _users.Remove(user);
        }

        public async Task<User> Get(string email)
            => _users.SingleOrDefault(x => x.Email == email.ToLowerInvariant());

        public async Task<User> Get(Guid id)
            => _users.SingleOrDefault(x => x.Id == id);

        public async Task<IEnumerable<User>> GetAll()
            => _users;

        public async Task Update(User user)
        {
            
        }
    }
}
