using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class CreateFriendshipHandler:ICommandHandler<CreateFriendship>
    {
        private readonly ICharacterDataService _characterDataService;
        public CreateFriendshipHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(CreateFriendship command)
        {
            throw new NotImplementedException();
        }
    }
}
