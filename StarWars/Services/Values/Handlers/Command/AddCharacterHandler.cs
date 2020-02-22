using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Command;
using Services.Values.Command;

namespace Services.Values.Handlers.Command
{
    public class AddCharacterHandler:ICommandHandler<AddCharacter>
    {
        private readonly IValuesService _valuesService;
        public AddCharacterHandler(IValuesService valuesService)
        {
            _valuesService = valuesService;
        }
        public Task HandleAsync(AddCharacter command)
        {
            throw new NotImplementedException();
        }
    }
}
