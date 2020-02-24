using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class CreateEpisodeHandler:ICommandHandler<CreateEpisode>
    {
        private readonly ICharacterDataService _characterDataService;
        public CreateEpisodeHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(CreateEpisode command)
        {
            await _characterDataService.CreateEpisodeAsync(command.Id,command.Title);
        }
    }
}
