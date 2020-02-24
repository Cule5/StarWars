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

        public Task HandleAsync(DeleteFriendship command)
        {
            throw new NotImplementedException();
        }
    }
}
