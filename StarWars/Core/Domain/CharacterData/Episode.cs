using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class Episode:Entity
    {
        protected Episode()
        {

        }
        public Episode(Guid id,string title) : base(id)
        {
            Title = title;
        }
        public string Title { get; protected set; }
        public ICollection<CharacterEpisode> CharacterEpisodes { get; protected set; }=new List<CharacterEpisode>();
    }
}
