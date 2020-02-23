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
            return await _dbContext.Characters
                .OrderBy(character => character.Name)
                .Skip((query.PageNumber - 1)*query.PageSize)
                .Take(query.PageSize)
                .Select(character=>new ExtendedCharacterDto(character.Id,character.Name,
                    character.Characters
                    .Select(friend=>new SimpleCharacterDto(friend.Id,friend.Name)),
                    character.Episodes
                    .Select(episode=>new SimpleEpisodeDto(episode.Id,episode.Title))))
                .ToListAsync();
        }
    }
}