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
        private readonly IEpisodeFactory _episodeFactory;
        private readonly ICharacterRepository _characterRepository;
        public CharacterDataService(ICharacterFactory characterFactory,IEpisodeFactory episodeFactory,ICharacterRepository characterRepository)
        {
            _characterFactory = characterFactory;
            _episodeFactory = episodeFactory;
            _characterRepository = characterRepository;
        }
        public async Task AddCharacterAsync(ExtendedCharacterDto extendedCharacterDto)
        {
            

            
        }

        public Task AddEpisodeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
