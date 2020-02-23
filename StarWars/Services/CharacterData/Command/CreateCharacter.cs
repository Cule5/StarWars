using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.CharacterData.Dto;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class CreateCharacter:ICommand
    {
        [JsonConstructor]
        public CreateCharacter(Guid id,string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
