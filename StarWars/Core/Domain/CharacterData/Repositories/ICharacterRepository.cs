using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.CharacterData.Repositories
{
    public interface ICharacterRepository
    {
        Task<Character> GetAsync(Guid id);
        Task AddAsync(Character character);
    }
}
