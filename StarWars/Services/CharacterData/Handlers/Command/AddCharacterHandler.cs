using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class AddCharacterHandler:ICommandHandler<AddCharacter>
    {
        private readonly ICharacterDataService _characterDataService;
        public AddCharacterHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public Task HandleAsync(AddCharacter command)
        {
            throw new NotImplementedException();
        }
    }
}
