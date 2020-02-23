using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CharacterData.Dto
{
    public class SimpleCharacterDto
    {
        public SimpleCharacterDto(Guid id,string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
