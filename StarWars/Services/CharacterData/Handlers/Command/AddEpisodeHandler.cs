using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class AddEpisodeHandler:ICommandHandler<AddEpisode>
    {
        private readonly ICharacterDataService _characterDataService;
        public AddEpisodeHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public Task HandleAsync(AddEpisode command)
        {
            throw new NotImplementedException();
        }
    }
}
