using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CharacterData.Dto
{
    public class ExtendedCharacterDto
    {
        public ExtendedCharacterDto(Guid id,string name,IEnumerable<SimpleCharacterDto>friends,IEnumerable<SimpleEpisodeDto>episodes)
        {
            Id = id;
            Name = name;
            Friends = friends;
            Episodes = episodes;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<SimpleCharacterDto> Friends { get; private set; }
        public IEnumerable<SimpleEpisodeDto> Episodes { get; private set; }
    }
}
