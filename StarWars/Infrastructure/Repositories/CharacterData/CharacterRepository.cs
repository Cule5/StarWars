using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData;
using Core.Domain.CharacterData.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.CharacterData
{
    public class CharacterRepository : ICharacterRepository
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

        public async Task<Character> GetByNameAsync(string name)
        {
            return await _dbContext.Characters.FirstOrDefaultAsync(character=>character.Name.Equals(name));
        }

        public async Task AddAsync(Character character)
        {
            await _dbContext.Characters.AddAsync(character);
            await _dbContext.SaveChangesAsync();
        }
    }
}
