using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Character;
using Core.Domain.Character.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories
{
    public class CharacterRepository:ICharacterRepository
    {
        private readonly AppDbContext _dbContext;
        public CharacterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Character> GetAsync(Guid id)
        {
            return await _dbContext.Characters.FindAsync(id);
        }

        public async Task AddAsync(Character character)
        {
            await _dbContext.Characters.AddAsync(character);
            await _dbContext.SaveChangesAsync();
        }
    }
}
