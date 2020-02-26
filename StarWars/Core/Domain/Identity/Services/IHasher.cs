using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Identity.Services
{
    public interface IHasher
    {
        Task<string> CreateAsync(User user, string secret, params string[] excludedCharacters);
        bool IsValidAsync(User user, string secret);
    }
}
