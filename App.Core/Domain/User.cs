using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public User(string email, string firstName, string lastName, string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
    }   
}
