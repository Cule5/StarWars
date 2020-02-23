using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.CharacterData.Command;
using Services.CharacterData.Query;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class CharacterDataController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        public CharacterDataController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        
        [HttpGet]
        [Route("single-character-info/{id}")]
        public async Task<IActionResult> SingleCharacterInfo([FromRoute]Guid id)
        {
            return Ok(await _queryDispatcher.DispatchAsync(new SingleCharacterInfo(id)));
        }

        [HttpGet]
        [Route("all-character-info")]
        public async Task<IActionResult> Test([FromQuery]AllCharactersInfo query)
        {
            return Ok(await _queryDispatcher.DispatchAsync(query));
        }

        [HttpPost]
        [Route("add-character")]
        public async Task<IActionResult> AddCharacter([FromBody]AddCharacter command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
        [HttpPut]
        [Route("add-episode")]
        public async Task<IActionResult> AddEpisode([FromBody]AddEpisode command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
