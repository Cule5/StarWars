using System;
using System.Collections.Generic;
using System.Linq;
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
        public virtual ICollection<CharacterEpisode> CharacterEpisodes { get; protected set; }=new List<CharacterEpisode>();

        public void AddCharacter(Character character)
        {
            var newCharacterEpisode = new CharacterEpisode(character.Id,Id);
            var result=CharacterEpisodes
                .FirstOrDefault(characterEpisode=>characterEpisode.CharacterId==character.Id&&characterEpisode.EpisodeId==Id);
            if (result != null) return;
            CharacterEpisodes.Add(newCharacterEpisode);
            character.CharactersEpisodes.Add(newCharacterEpisode);
        }
    }
}
