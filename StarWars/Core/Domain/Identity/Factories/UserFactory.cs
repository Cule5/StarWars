using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Identity.Repositories;

namespace Core.Domain.Identity.Factories
{
    public class UserFactory:IUserFactory
    {
        private readonly IUserRepository _userRepository;
        public UserFactory(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> CreateAsync(string email, string password)
        {
            var dbUser = await _userRepository.GetByEmailAsync(email);
            if (dbUser != null)
                throw new DomainException("User with given email already exists");
            return new User(email,password);
        }
    }
}
