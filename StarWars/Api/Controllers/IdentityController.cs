using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.Identity.Command;
using Services.Identity.Query;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class IdentityController:Controller
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        public IdentityController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }
        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignIn([FromBody]SignIn query)
        {
            return Ok(await _queryDispatcher.DispatchAsync(query));
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignUp([FromBody]SignUp command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

    }
}
