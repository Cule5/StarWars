using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Character
{
    public class Character:AggregateRoot
    {
        protected Character()
        {

        }

        public Character(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        public virtual ICollection<Character> Characters { get; protected set; }=new List<Character>();
        public virtual ICollection<Episode.Episode> Episodes { get; protected set; }=new List<Episode.Episode>();
    }
}
