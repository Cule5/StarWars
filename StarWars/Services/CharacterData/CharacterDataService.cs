using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData;
using Core.Domain.CharacterData.Factories;
using Core.Domain.CharacterData.Repositories;
using Infrastructure.EntityFramework;
using Services.CharacterData.Dto;

namespace Services.CharacterData
{
    public class CharacterDataService:ICharacterDataService
    {
        private readonly ICharacterFactory _characterFactory;
        private readonly IEpisodeFactory _episodeFactory;
        private readonly IFriendshipFactory _friendshipFactory;
        private readonly ICharacterRepository _characterRepository;
        private readonly IEpisodeRepository _episodeRepository;
        private readonly IFriendshipRepository _friendshipRepository;

        private readonly AppDbContext _dbContext;
        public CharacterDataService(
            ICharacterFactory characterFactory,
            IEpisodeFactory episodeFactory,
            IFriendshipFactory friendshipFactory,
            ICharacterRepository characterRepository,
            IEpisodeRepository episodeRepository,
            IFriendshipRepository friendshipRepository,
            AppDbContext dbContext)
        {
            _characterFactory = characterFactory;
            _episodeFactory = episodeFactory;
            _friendshipFactory = friendshipFactory;
            _characterRepository = characterRepository;
            _episodeRepository = episodeRepository;
            _friendshipRepository = friendshipRepository;
            _dbContext = dbContext;
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

        public async Task CreateFriendshipAsync(Guid characterId, IEnumerable<Guid> friends)
        {
            var dbCharacter=await _characterRepository.GetAsync(characterId);
            if(dbCharacter==null)
                throw new Exception("");
            foreach (var friendId in friends)
            {
                var friend = await _characterRepository.GetAsync(friendId);
                if (friend == null) continue;
                var friendship = await _friendshipFactory.CreateAsync(dbCharacter.Id, friendId);
                await _friendshipRepository.AddAsync(friendship);
            }
            
        }

        public async Task AddEpisodesToCharacter(Guid characterId, IEnumerable<Guid> episodes)
        {
            var dbCharacter = await _characterRepository.GetAsync(characterId);
            if(dbCharacter==null)
                throw new Exception("");
            foreach (var episodeId in episodes)
            {
                var dbEpisode=await _episodeRepository.GetAsync(episodeId);
                //if (dbEpisode != null&&!dbCharacter.)
                //{
                    
                //}
            }

            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteFriendship(Guid characterA,Guid characterB)
        {
            throw new NotImplementedException();
        }
    }
}
