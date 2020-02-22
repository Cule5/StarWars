using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Services.CharacterData.Dto;
using Services.Common.Query;

namespace Services.CharacterData.Query
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
