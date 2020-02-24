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
        public virtual ICollection<CharacterEpisode> CharactersEpisodes { get; protected set; } = new List<CharacterEpisode>();
        public virtual ICollection<Friendship> FriendshipsA { get; protected set; }=new List<Friendship>();
        public virtual ICollection<Friendship> FriendshipsB { get; protected set; }=new List<Friendship>();
    }
}
