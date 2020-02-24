using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class CharacterEpisode:Entity
    {
        protected CharacterEpisode()
        {

        }

        public CharacterEpisode(Guid characterId,Guid episodeId)
        {
            CharacterId = characterId;
            EpisodeId = episodeId;
        }
        public Guid CharacterId { get; protected set; }
        public virtual Character Character { get; protected set; }
        public Guid EpisodeId { get; protected set; }
        public virtual Episode Episode { get; protected set; }
    }
}
