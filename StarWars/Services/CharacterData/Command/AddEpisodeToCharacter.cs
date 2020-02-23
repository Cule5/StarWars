using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.CharacterData.Dto;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class AddEpisodeToCharacter : ICommand
    {
        [JsonConstructor]
        public AddEpisodeToCharacter(Guid episodeId,Guid characterId)
        {
            EpisodeId = episodeId;
            CharacterId = characterId;
        }
        public Guid EpisodeId { get; private set; }
        public Guid CharacterId { get; private set; }
    }
}
