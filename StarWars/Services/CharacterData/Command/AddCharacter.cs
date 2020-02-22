using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class AddCharacter:ICommand
    {
        [JsonConstructor]
        public AddCharacter(Guid id,string name,IEnumerable<string>friends,IEnumerable<string>episodes)
        {
            Id = id;
            Name = name;
            Friends = friends;
            Episodes = episodes;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<string> Friends { get; private set; }
        public IEnumerable<string> Episodes { get; private set; }
    }
}
