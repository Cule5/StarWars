using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Character.Factories
{
    public interface ICharacterFactory
    {
        Task<Character> CreateAsync(Guid id);
    }
}
