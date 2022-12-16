using Microsoft.AspNetCore.Mvc;
using Univ_WebSite_Api_Core.Appcode;
using Univ_WebSite_Api_Core.Models;
using Univ_WebSite_Api_Core.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univ_WebSite_Api_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _ipersonService;

        public PersonController(IPersonService ipersonService)
        {
            _ipersonService = ipersonService;
        }



        // GET: api/<PersonController>
        [HttpGet]
        public List<Person> Get()
        {
            return _ipersonService.SelectAll();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _ipersonService.SelectByID(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public int Post(Person person)
        {
          return  _ipersonService.Insert(person);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public int Put(Person person)
        {
            return _ipersonService.Update(person);  
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _ipersonService.Delete(id);
        }
    }
}
