using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Identity.Factories;
using Core.Domain.Identity.Repositories;
using Infrastructure.Authentication;

namespace Services.Identity
{
    public class IdentityService:IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;
        public IdentityService(IUserRepository userRepository,IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task SignUpAsync(Guid userId,string email, string password)
        {
            var newUser=await _userFactory.CreateAsync(userId,email, password);
            await _userRepository.AddAsync(newUser);
        }
    }
}
