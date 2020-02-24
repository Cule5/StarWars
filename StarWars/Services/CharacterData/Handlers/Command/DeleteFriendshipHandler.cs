using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Command;
using Services.Common.Command;

namespace Services.CharacterData.Handlers.Command
{
    public class DeleteFriendshipHandler:ICommandHandler<DeleteFriendship>
    {
        private readonly ICharacterDataService _characterDataService;
        public DeleteFriendshipHandler(ICharacterDataService characterDataService)
        {
            _characterDataService = characterDataService;
        }
        public async Task HandleAsync(DeleteFriendship command)
        {
            await _characterDataService.DeleteFriendship(command.CharacterA, command.CharacterB);
        }
    }
}
