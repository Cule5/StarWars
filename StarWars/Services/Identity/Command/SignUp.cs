using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.Identity.Command
{
    public class SignUp:ICommand
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        [JsonConstructor]
        public SignUp(string email,string password)
        {
            Email = email;
            Password = password;
        }
    }
}
