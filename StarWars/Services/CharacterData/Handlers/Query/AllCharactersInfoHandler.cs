using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.CharacterData.Dto;
using Services.CharacterData.Query;
using Services.Common.Query;

namespace Services.CharacterData.Handlers.Query
{
    public class AllCharactersInfoHandler:IQueryHandler<AllCharactersInfo,IEnumerable<ExtendedCharacterDto>>
    {
        private readonly AppDbContext _dbContext;
        public AllCharactersInfoHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<ExtendedCharacterDto>> HandleAsync(AllCharactersInfo query)
        {
            //var result=_dbContext.Characters.Select(character=>new{Friends= character.FriendshipsA
            //    .Select(friendship => new SimpleCharacterDto(friendship.CharacterBId, friendship.CharacterB.Name))
            //    .Concat(character.FriendshipsB
            //        .Select(friendship => new SimpleCharacterDto(friendship.CharacterAId, friendship.CharacterA.Name)))});

            return await _dbContext.Characters
                .OrderBy(character => character.Name)
                .Skip((query.PageNumber - 1) * query.PageSize)
                .Take(query.PageSize)
                .Select(character=>new ExtendedCharacterDto(character.Id,character.Name,character.FriendshipsA
                    .Select(friendship=>new SimpleCharacterDto(friendship.CharacterBId,friendship.CharacterB.Name))
                    .Concat(character.FriendshipsB
                        .Select(friendship=>new SimpleCharacterDto(friendship.CharacterAId, friendship.CharacterA.Name))),
                    character.CharactersEpisodes
                        .Select(characterEpisode=>new SimpleEpisodeDto(characterEpisode.EpisodeId,characterEpisode.Episode.Title))))
                .ToListAsync();
        }
    }
}