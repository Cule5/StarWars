using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.CharacterData.Dto;
using Services.CharacterData.Query;
using Services.Common.Query;

namespace Services.CharacterData.Handlers.Query
{
    class SingleCharacterInfoHandler:IQueryHandler<SingleCharacterInfo,CharacterDto>
    {
        private readonly AppDbContext _dbContext;
        public SingleCharacterInfoHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<CharacterDto> HandleAsync(SingleCharacterInfo query)
        {
            throw new NotImplementedException();
        }
    }
}
