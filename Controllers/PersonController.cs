using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnet_core.Services;
using aspnet_core.Models;

namespace aspnet_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return _personService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return _personService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            _personService.Create(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            _personService.Update(value, id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
