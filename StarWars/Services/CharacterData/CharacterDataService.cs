using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData.Repositories;

namespace Services.CharacterData
{
    public class CharacterDataService:ICharacterDataService
    {
        private readonly ICharacterRepository _characterRepository;
        public CharacterDataService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }
        public Task AddCharacterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
