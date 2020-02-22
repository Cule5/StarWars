using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData.Repositories;

namespace Core.Domain.CharacterData.Factories
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly ICharacterRepository _characterRepository;
        public CharacterFactory(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }
        public Task<Character> CreateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
