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
        private static Character knight = new Character();

        //GET method
        [HttpGet]
        public ActionResult<Character> Get() {
            return Ok(knight);
        }
    }
}