using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.CharacterData.Factories
{
    public interface IFriendshipFactory
    {
        Task<Friendship> CreateAsync(Guid characterA,Guid characterB);
    }
}
