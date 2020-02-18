using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Common.Command
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        System.Threading.Tasks.Task HandleAsync(T command);
    }
}
