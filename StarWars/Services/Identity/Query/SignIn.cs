using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Authentication;
using Newtonsoft.Json;
using Services.Common.Query;

namespace Services.Identity.Query
{
    public class SignIn:IQuery<JsonWebToken>
    {
        [JsonConstructor]
        public SignIn(string email,string password)
        {
            Email = email;
            Password = password;
        }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
