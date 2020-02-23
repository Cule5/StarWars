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
        private readonly IEpisodeRepository _episodeRepository;
        public CharacterDataService(
            ICharacterFactory characterFactory,
            IEpisodeFactory episodeFactory,
            ICharacterRepository characterRepository,
            IEpisodeRepository episodeRepository)
        {
            _characterFactory = characterFactory;
            _episodeFactory = episodeFactory;
            _characterRepository = characterRepository;
            _episodeRepository = episodeRepository;
        }
        public async Task CreateCharacterAsync(Guid id,string name)
        {
            var newCharacter=await _characterFactory.CreateAsync(id, name);
            await _characterRepository.AddAsync(newCharacter);
        }
        public async Task CreateEpisodeAsync(Guid id, string title)
        {
            var newEpisode = await _episodeFactory.CreateAsync(id,title);
            await _episodeRepository.AddAsync(newEpisode);
        }
    }
}
