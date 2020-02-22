using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.CharacterData
{
    public class Episode:Entity
    {
        public Episode(Guid id,string title) : base(id)
        {
            Title = title;
        }
        public string Title { get; protected set; }

    }
}
