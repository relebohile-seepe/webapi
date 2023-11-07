using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace heroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private Hero[] heroes = new Hero[] {
               new Hero()
               {
                   name= "Hulk",
                   power="Strength from gamma radiation",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 5000 ),
                       new KeyValuePair<string, int>( "intelligence", 50),
                       new KeyValuePair<string, int>( "stamina", 2500 )
                   }
               }
            };

        // GET: api/Heroes
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return this.heroes;
        }

        // GET: api/Heroes/5
        [HttpGet("{id}", Name = "Get")]
        public Hero Get(int id)
        {
            return this.heroes;
        }

[HttpPost]
// This is a controller action method that handles HTTP POST requests.
// It expects a Hero object in the request body and an optional 'action' parameter in the query string.
public IActionResult Post([FromBody] Hero hero, [FromQuery] string action = "none")
{
    // Check if the 'hero' object is null. If it is, return a 400 Bad Request response with an error message.
    if (hero == null)
    {
        return BadRequest("Hero object is not provided.");
    }

    // Check if the 'action' parameter is set to "evolve".
    if (action == "evolve")
    {
        // If 'action' is "evolve," call the 'evolve' method on the 'hero' object.
        hero.evolve();

        // Return a 200 OK response with the evolved 'hero' object.
        return Ok(hero);
    }

    // If the 'action' parameter is not "evolve," return a 400 Bad Request response with an error message.
    return BadRequest("Invalid action. Supported actions: 'evolve'");
}




        // PUT: api/Heroes/5
        [HttpPut("{id}")]
        public Hero Put(int id, [FromBody] Hero hero)
        {
      
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
