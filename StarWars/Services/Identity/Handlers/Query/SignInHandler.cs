using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Identity.Services;
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
        private readonly IHasher _hasher;
        public SignInHandler(AppDbContext dbContext,IJwtProvider jwtProvider,IHasher hasher)
        {
            _dbContext = dbContext;
            _jwtProvider = jwtProvider;
            _hasher = hasher;
        }

        public async Task<JsonWebToken> HandleAsync(SignIn query)
        {
            var dbUser = await _dbContext.Users
                .FirstOrDefaultAsync(user=>user.Email.Equals(query.Email));
            if (dbUser == null || !_hasher.IsValidAsync(dbUser, query.Password))
                throw new ServiceException("Invalid email or password");
            
            return _jwtProvider.CreateToken(dbUser.Id);

        }
    }
}
