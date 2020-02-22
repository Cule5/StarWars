using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Identity
{
    public class User:AggregateRoot
    {
        public string Email { get; protected set; }
        public string Password { get; protected set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
