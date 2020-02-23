using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Services.CharacterData.Dto;
using Services.Common.Query;

namespace Services.CharacterData.Query
{
    public class SingleCharacterInfo:IQuery<ExtendedCharacterDto>
    {
        public SingleCharacterInfo(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
