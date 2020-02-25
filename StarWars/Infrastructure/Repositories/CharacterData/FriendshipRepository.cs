using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData;
using Core.Domain.CharacterData.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.CharacterData
{
    public class FriendshipRepository:IFriendshipRepository
    {
        private readonly AppDbContext _dbContext;
        public FriendshipRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Friendship> GetAsync(Guid id)
        {
            return await _dbContext.Friendships.FindAsync(id);
        }

        public async Task AddAsync(Friendship friendship)
        {
            await _dbContext.Friendships.AddAsync(friendship);
            await _dbContext.SaveChangesAsync();
        }

        public bool Exists(Guid characterA, Guid characterB)
        {
            var dbFriendship = _dbContext.Friendships
                .FirstOrDefault(friendship=>
                    (friendship.CharacterAId==characterA&&friendship.CharacterBId==characterB)||
                    (friendship.CharacterAId == characterB && friendship.CharacterBId == characterA));
            return dbFriendship != null;
        }

        public async Task DeleteAsync(Guid characterA, Guid characterB)
        {
            var dbFriendship = await _dbContext.Friendships
                .FirstOrDefaultAsync(friendship =>
                    (friendship.CharacterAId == characterA && friendship.CharacterBId == characterB) ||
                    (friendship.CharacterAId == characterB && friendship.CharacterBId == characterA));
            if (dbFriendship != null)
                _dbContext.Friendships.Remove(dbFriendship);
        }
    }
}
