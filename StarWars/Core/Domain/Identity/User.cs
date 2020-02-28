using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Domain.Identity
{
    public class User:AggregateRoot
    {
        private string _emailRegex = @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public string Email { get; protected set; }

        public  string PasswordHash { get; protected set; }

        protected User() { }

        public User(Guid id, string email) : base(id)
        {
            SetEmail(email);
        }

        private void SetEmail(string email)
        {
            email = email.ToLowerInvariant();
            if (!Regex.IsMatch(email, _emailRegex))
            {
                throw new DomainException("Email is incorrect.");
            }

            Email = email;
        }

        public virtual void SetPasswordHash(string passwordHash)
        {
            PasswordHash = passwordHash;
        }
    }
}
