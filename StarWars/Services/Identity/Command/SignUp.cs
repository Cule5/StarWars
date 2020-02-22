using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.Identity.Command
{
    public class SignUp:ICommand
    {
        public Guid UserId { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        [JsonConstructor]
        public SignUp(Guid userId,string email,string password)
        {
            UserId = userId;
            Email = email;
            Password = password;
        }
    }
}
