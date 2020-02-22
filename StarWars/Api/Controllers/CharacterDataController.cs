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
        [Route("single-character-info/{characterName}")]
        public async Task<IActionResult> SingleCharacterInfo([FromRoute]string characterName)
        {
            return Ok(await _queryDispatcher.DispatchAsync(new SingleCharacterInfo(characterName)));
        }

        [HttpGet]
        [Route("character-info")]
        public async Task<IActionResult> Test([FromQuery]CharactersInfo query)
        {
            return Ok(await _queryDispatcher.DispatchAsync(query));
        }

        [HttpGet]
        [Route("all-character-info")]
        public async Task<IActionResult> AllCharacterInfo()
        {
            return Ok();
        }

        [HttpPost]
        [Route("add-character")]
        public async Task<IActionResult> AddCharacter([FromBody]AddCharacter command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
