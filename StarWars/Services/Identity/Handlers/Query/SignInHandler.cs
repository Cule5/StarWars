using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Identity.Query;

namespace Services.Identity.Handlers.Query
{
    public class SignInHandler:IQueryHandler<SignIn,JsonWebToken>
    {
        private readonly AppDbContext _dbContext;
        private readonly IJwtProvider _jwtProvider;
        public SignInHandler(AppDbContext dbContext,IJwtProvider jwtProvider)
        {
            _dbContext = dbContext;
            _jwtProvider = jwtProvider;
        }

        public async Task<JsonWebToken> HandleAsync(SignIn query)
        {
            var dbUser=await _dbContext.Users
                .FirstOrDefaultAsync(user=>user.Email.Equals(query.Email)&&user.Password.Equals(query.Password));
            if(dbUser==null)
                throw new Exception("Invalid email or password");
            return _jwtProvider.CreateToken(dbUser.Id);

        }
    }
}
