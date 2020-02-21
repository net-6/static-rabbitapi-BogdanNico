using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rabbitapi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rabbitapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitapiController : ControllerBase
    {
        private static List<Rabbit> myRabbits = new List<Rabbit>();

        public RabbitapiController ()

        {
            Rabbit bunny = new Rabbit("Ion", Rabbit.FurColors.Black, Rabbit.EyeColors.Blue, Rabbit.Genders.Male, 5, 1);
            Rabbit buggsbunny = new Rabbit("Ana", Rabbit.FurColors.Brown, Rabbit.EyeColors.Red, Rabbit.Genders.Female, 6, 2);

            if (!myRabbits.Any())
            {
                myRabbits.Add(bunny);
                myRabbits.Add(buggsbunny);
            }
        }

        // GET: api/Rabbitapi
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            return myRabbits;
        }

        // GET api/Rabbitapi/2
        [HttpGet("{id}", Name = "Get")]
        public Rabbit Get(int id)
        {
            Rabbit buggsbunny = new Rabbit("Ana", Rabbit.FurColors.Brown, Rabbit.EyeColors.Red, Rabbit.Genders.Female, 6, 2);
            return buggsbunny;  
        }

        // POST api/Rabbitapi
        [HttpPost]
        public IActionResult Post([FromBody] Rabbit model)
        {
            if (ModelState.IsValid)
            {
                //save in 'database'
                myRabbits.Add(model);
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/Rabbitapi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
