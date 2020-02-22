using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Values.Dto;
using Services.Values.Query;

namespace Services.Values.Handlers.Query
{
    public class CharactersInfoHandler:IQueryHandler<CharactersInfo,IEnumerable<CharacterDto>>
    {
        private readonly AppDbContext _dbContext;
        public CharactersInfoHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CharacterDto>> HandleAsync(CharactersInfo query)
        {
            return await _dbContext.Characters
                .OrderBy(character => character.Name)
                .Skip((query.PageNumber - 1)*query.PageSize)
                .Take(query.PageSize).Select(character=>new CharacterDto())
                .ToListAsync();
        }
    }
}