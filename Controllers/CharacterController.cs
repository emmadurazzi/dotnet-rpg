using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    //we add the ApiController attribute in order to serve HTTP API responses
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        //GET methods
        //quando vi sono più metodi dello stesso tipo vanno inseriti degli attributi alla radice(url) in modo che possano essere distitnti
        [HttpGet("GetAllCharacter")]
        public async Task<ActionResult<List<Character>>> GetAll() {
            return Ok(await _characterService.GetAllCharacter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id) {
            return Ok(await _characterService.GetCharacterByID(id));
        }

        //POST method
        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter) {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}