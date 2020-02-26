using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Identity.Repositories;
using Core.Domain.Identity.Services;

namespace Core.Domain.Identity.Factories
{
    public class UserFactory:IUserFactory
    {
        private readonly IUserRepository _userRepository;
        private readonly IHasher _hasher;
        public UserFactory(IUserRepository userRepository,IHasher hasher)
        {
            _userRepository = userRepository;
            _hasher = hasher;
        }
        public async Task<User> CreateAsync(Guid userId,string email, string password)
        {
            var dbUser = await _userRepository.GetByEmailAsync(email);
            if (dbUser != null)
                throw new DomainException("User with given email already exists");
            var newUser= new User(userId,email);

            var passwordHash = await _hasher.CreateAsync(newUser, password);
            newUser.SetPasswordHash(passwordHash);
            return newUser;
        }
    }
}
