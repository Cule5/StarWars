using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.CharacterData.Dto;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class CreateCharacterCharacterHandler:ICommandHandler<CreateCharacter>
    {
        private readonly ICharacterDataService _characterDataService;
        public CreateCharacterCharacterHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(CreateCharacter command)
        {
            await _characterDataService.CreateCharacterAsync(command.Id,command.Name);
        }
    }
}
