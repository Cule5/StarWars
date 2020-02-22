using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Character.Repositories
{
    public interface ICharacterRepository
    {
        Task<Character> GetAsync(Guid id);
        Task AddAsync(Character character);
    }
}
