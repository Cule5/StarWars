using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Authentication
{
    public class JwtProvider:IJwtProvider
    {

        public JsonWebToken CreateToken(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
