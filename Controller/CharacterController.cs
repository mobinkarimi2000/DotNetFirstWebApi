 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFirstWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    { 
        private static  Character knight=new();


        [HttpGet()]
        public ActionResult<Character> Get(){
Console.WriteLine(knight);
            return knight==null?NotFound(): Ok(knight);
        }
    }
}