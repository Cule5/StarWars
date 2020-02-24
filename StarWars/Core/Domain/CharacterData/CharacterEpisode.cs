using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class CharacterEpisode:Entity
    {
        public Guid CharacterId { get; protected set; }
        public Character Character { get; protected set; }
        public Guid EpisodeId { get; protected set; }
        public Episode Episode { get; protected set; }
    }
}
