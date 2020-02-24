using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class Friendship:AggregateRoot
    {
        protected Friendship()
        {

        }

        public Friendship(Guid characterA,Guid characterB)
        {
            CharacterAId = characterA;
            CharacterBId = characterB;
        }
        public Guid CharacterAId { get; protected set; }
        public virtual Character CharacterA { get; protected set; }
        public Guid CharacterBId { get; protected set; }
        public virtual Character CharacterB { get; protected set; }
    }
}
