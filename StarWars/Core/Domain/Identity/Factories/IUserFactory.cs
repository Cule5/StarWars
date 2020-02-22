using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Identity.Factories
{
    public interface IUserFactory
    {
        Task<User> CreateAsync(string email,string password);
    }
}
