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

        public Character(Guid id, string name) : base(id)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; protected set; }
        public virtual ICollection<Character> Characters { get; protected set; } = new List<Character>();
        public virtual ICollection<Episode> Episodes { get; protected set; } = new List<Episode>();
    }
}
