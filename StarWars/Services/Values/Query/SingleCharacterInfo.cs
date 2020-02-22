using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Services.Common.Query;
using Services.Values.Dto;

namespace Services.Values.Query
{
    public class SingleCharacterInfo:IQuery<CharacterDto>
    {
        public string CharacterName { get; private set; }
        public SingleCharacterInfo(string characterName)
        {
            CharacterName = characterName;
        }
    }
}
