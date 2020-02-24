using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class CreateFriendship:ICommand
    {
        [JsonConstructor]
        public CreateFriendship(Guid characterId, IEnumerable<Guid> friends)
        {
            CharacterId = characterId;
            Friends = friends;
        }
        public Guid CharacterId { get; }
        public IEnumerable<Guid> Friends { get; }
    }
}
