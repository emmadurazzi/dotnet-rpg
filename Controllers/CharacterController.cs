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
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        //GET methods
        //quando vi sono più metodi dello stesso tipo vanno inseriti degli attributi alla radice(url) in modo che possano essere distitnti
        [HttpGet("GetAllCharacter")]
        public ActionResult<List<Character>> Get() {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        //POST method
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}