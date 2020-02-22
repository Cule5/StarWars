using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Query;
using Services.Values.Dto;

namespace Services.Values.Query
{
    public class CharactersInfo:IQuery<IEnumerable<CharacterDto>>
    {
        public int PageNumber { get; private set; } = 1;
        public int PageSize { get; private set; } = 20;
        
        [JsonConstructor]
        public CharactersInfo(int pageNumber,int pageSize)
        {

        }
    }
}
