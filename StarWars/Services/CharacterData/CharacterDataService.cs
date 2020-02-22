using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData.Factories;
using Core.Domain.CharacterData.Repositories;
using Services.CharacterData.Dto;

namespace Services.CharacterData
{
    public class CharacterDataService:ICharacterDataService
    {
        private readonly ICharacterFactory _characterFactory;
        private readonly ICharacterRepository _characterRepository;
        public CharacterDataService(ICharacterFactory characterFactory,ICharacterRepository characterRepository)
        {
            _characterFactory = characterFactory;
            _characterRepository = characterRepository;
        }
        public async Task AddCharacterAsync(CharacterDto characterDto)
        {
            
        }
    }
}
