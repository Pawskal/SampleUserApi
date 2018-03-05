using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleUserApi.Services;
using SampleUserApi.Models;

namespace SampleUserApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private UserService _service;
        public ValuesController(UserService service){
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<User>> Get(){
            return await _service.GetList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
