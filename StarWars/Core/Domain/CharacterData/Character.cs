using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class Character : AggregateRoot
    {
        protected Character()
        {

        }

        public Character(Guid id, string name,ICollection<Character>characters,ICollection<Episode>episodes) : base(id)
        {
            Name = name;
            Characters = characters;
            Episodes = episodes;
        }
        public string Name { get; protected set; }
        public virtual ICollection<Character> Characters { get; protected set; } = new List<Character>();
        public virtual ICollection<Episode> Episodes { get; protected set; } = new List<Episode>();
        

    }
}
