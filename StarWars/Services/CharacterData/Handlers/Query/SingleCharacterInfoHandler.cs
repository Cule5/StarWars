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
            return new ExtendedCharacterDto(dbCharacter.Id,dbCharacter.Name,dbCharacter.Characters
                .Select(character=>new SimpleCharacterDto(character.Id,character.Name)),dbCharacter.Episodes
                .Select(episode=>new SimpleEpisodeDto(episode.Id,episode.Title)));
        }
    }
}
