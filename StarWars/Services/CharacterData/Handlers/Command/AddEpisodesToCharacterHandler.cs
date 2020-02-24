using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class AddEpisodesToCharacterHandler:ICommandHandler<AddEpisodesToCharacter>
    {
        private readonly ICharacterDataService _characterDataService;
        public AddEpisodesToCharacterHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(AddEpisodesToCharacter command)
        {
            await _characterDataService.AddEpisodesToCharacter(command.CharacterId, command.Episodes);
        }
    }
}
