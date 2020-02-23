using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<Character> CreateAsync(Guid id, string name, IEnumerable<Character> friends, IEnumerable<Episode> episodes)
        {
            var dbCharacter=await _characterRepository.GetByNameAsync(name);
            if(dbCharacter!=null)
                throw new DomainException("Character with given name already exists");

            return new Character(id,name,friends.ToList(),episodes.ToList());
        }
    }
}
