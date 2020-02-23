using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CharacterData.Dto
{
    public class ExtendedEpisodeDto
    {
        public ExtendedEpisodeDto(Guid id,IEnumerable<SimpleCharacterDto>characters)
        {
            Id = id;
            Characters = characters;
        }
        public Guid Id { get; private set; }
        public IEnumerable<SimpleCharacterDto> Characters { get; private set; }
    }
}
