using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.CharacterData.Dto;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class AddEpisodesToCharacter : ICommand
    {
        [JsonConstructor]
        public AddEpisodesToCharacter(Guid characterId, IEnumerable<Guid> episodes)
        {
            CharacterId = characterId;
            Episodes = episodes;
        }
        public Guid CharacterId { get; private set; }
        public IEnumerable<Guid> Episodes { get; private set; }
        
    }
}
