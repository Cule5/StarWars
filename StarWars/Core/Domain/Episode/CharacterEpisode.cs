using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Episode
{
    public class CharacterEpisode
    {
        protected CharacterEpisode()
        {

        }
        public Guid CharacterId { get; protected set; }
        public virtual Character.Character Character {get; protected set; }
        public Guid EpisodeId { get; protected set; }
        public virtual Episode Episode { get; protected set; }
    }
}
