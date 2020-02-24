using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData.Repositories;

namespace Core.Domain.CharacterData.Factories
{
    public class FriendshipFactory:IFriendshipFactory
    {
        private readonly IFriendshipRepository _friendshipRepository;
        public FriendshipFactory(IFriendshipRepository friendshipRepository)
        {
            _friendshipRepository = friendshipRepository;
        }
        public Task<Friendship> CreateAsync(Guid characterA, Guid characterB)
        {
            return Task.Factory.StartNew(() =>
            {
                if (_friendshipRepository.Exists(characterA, characterB))
                    throw new DomainException("Friendship between characters already exists");

                return new Friendship(characterA, characterB);
            });
        }
    }
}
