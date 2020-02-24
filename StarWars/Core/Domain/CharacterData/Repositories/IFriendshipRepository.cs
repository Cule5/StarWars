using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.CharacterData.Repositories
{
    public interface IFriendshipRepository
    {
        Task<Friendship> GetAsync(Guid id);
        Task AddAsync(Friendship friendship);
        bool Exists(Guid characterA,Guid characterB);
        Task DeleteAsync(Guid characterA,Guid characterB);
    }
}
