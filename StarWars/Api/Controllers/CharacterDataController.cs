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
        [Route("create-character")]
        public async Task<IActionResult> CreateCharacter([FromBody]CreateCharacter command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpPost]
        [Route("create-episode")]
        public async Task<IActionResult> CreateEpisode([FromBody]CreateEpisode command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpPost]
        [Route("add-episodes-to-character")]
        public async Task<IActionResult> AddEpisodeToCharacter([FromBody]AddEpisodesToCharacter command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
        [HttpPost]
        [Route("create-friendship")]
        public async Task<IActionResult> CreateFriendship([FromBody]CreateFriendship command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

    }
}
