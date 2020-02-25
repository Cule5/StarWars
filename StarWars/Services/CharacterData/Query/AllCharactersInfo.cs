using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.CharacterData.Dto;
using Services.Common.Query;

namespace Services.CharacterData.Query
{
    public class AllCharactersInfo:IQuery<IEnumerable<ExtendedCharacterDto>>
    {
        public int PageNumber { get; private set; } = 1;
        public int PageSize { get; private set; } = 20;
        
        
        public AllCharactersInfo(int pageNumber,int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
