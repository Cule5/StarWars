using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.CharacterData.Dto;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class CreateCharacterHandler:ICommandHandler<CreateCharacter>
    {
        private readonly ICharacterDataService _characterDataService;
        public CreateCharacterHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(CreateCharacter command)
        {
            await _characterDataService.CreateCharacterAsync(command.Id,command.Name);
        }
    }
}
