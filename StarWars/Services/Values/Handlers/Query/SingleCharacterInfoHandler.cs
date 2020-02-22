using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.Common.Query;
using Services.Values.Dto;
using Services.Values.Query;

namespace Services.Values.Handlers.Query
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
