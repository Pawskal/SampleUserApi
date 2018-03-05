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
    public class UsersController : Controller
    {
        private UserService _service;
        public UsersController(UserService service){
            _service = service;
        }

        // GET api/users
        [HttpGet]
        public async Task<IEnumerable<User>> Get(){
            return await _service.GetList();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            return await _service.Find(id);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]User user)
        {
            Console.WriteLine(user.ToString());
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
