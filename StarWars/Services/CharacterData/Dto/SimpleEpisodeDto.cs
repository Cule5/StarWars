using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CharacterData.Dto
{
    public class SimpleEpisodeDto
    {
        public SimpleEpisodeDto(Guid id,string title)
        {
            Id = id;
            Title = title;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
    }
}
