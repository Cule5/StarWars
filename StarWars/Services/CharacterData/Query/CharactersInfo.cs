using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.CharacterData.Dto;
using Services.Common.Query;

namespace Services.CharacterData.Query
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
