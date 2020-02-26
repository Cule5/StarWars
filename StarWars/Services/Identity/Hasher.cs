using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Identity;
using Core.Domain.Identity.Services;
using Microsoft.AspNetCore.Identity;

namespace Services.Identity
{
    public class Hasher:IHasher
    {
        private readonly IPasswordHasher<User> _hasher;

        public Hasher(IPasswordHasher<User> hasher)
        {
            _hasher = hasher;
        }
        public async Task<string> CreateAsync(User user, string secret, params string[] excludedCharacters)
        {
            return await Task.Run(() =>
            {
                var hash = _hasher.HashPassword(user, secret);
                return excludedCharacters
                    .Aggregate(hash, (current, excludedCharacter) => current
                        .Replace(excludedCharacter, string.Empty));
            });
        }

        public bool IsValidAsync(User user, string secret)
            => _hasher
                   .VerifyHashedPassword(user, user.PasswordHash, secret) == PasswordVerificationResult.Success;
    }
}
