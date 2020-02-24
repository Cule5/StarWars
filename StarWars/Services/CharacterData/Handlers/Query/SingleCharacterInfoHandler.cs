using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.CharacterData.Dto;
using Services.CharacterData.Query;
using Services.Common.Query;

namespace Services.CharacterData.Handlers.Query
{
    class SingleCharacterInfoHandler:IQueryHandler<SingleCharacterInfo,ExtendedCharacterDto>
    {
        private readonly AppDbContext _dbContext;
        public SingleCharacterInfoHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ExtendedCharacterDto> HandleAsync(SingleCharacterInfo query)
        {
            var dbCharacter=await _dbContext.Characters
                .FindAsync(query.Id);
            if (dbCharacter == null)
                throw new Exception("");
            return new ExtendedCharacterDto(dbCharacter.Id, dbCharacter.Name, dbCharacter.FriendshipsA
                .Select(friendship => new SimpleCharacterDto(friendship.CharacterBId, friendship.CharacterB.Name))
                .Concat(dbCharacter.FriendshipsB
                        .Select(friendship =>
                            new SimpleCharacterDto(friendship.CharacterAId, friendship.CharacterA.Name))),
                    dbCharacter.CharactersEpisodes
                        .Select(characterEpisode=>new SimpleEpisodeDto(characterEpisode.EpisodeId,characterEpisode.Episode.Title)));
        }
    }
}
