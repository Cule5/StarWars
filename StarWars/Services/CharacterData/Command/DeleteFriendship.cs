using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class DeleteFriendship:ICommand
    {
        [JsonConstructor]
        public DeleteFriendship(Guid characterA,Guid characterB)
        {
            CharacterA = characterA;
            CharacterB = characterB;
        }
        public Guid CharacterA { get; private set; }
        public Guid CharacterB { get; private set; }
    }
}
