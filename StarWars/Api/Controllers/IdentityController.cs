using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;

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
        public async Task<IActionResult> SignIn()
        {
            return Ok();
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignUp()
        {
            return Ok();
        }

    }
}
