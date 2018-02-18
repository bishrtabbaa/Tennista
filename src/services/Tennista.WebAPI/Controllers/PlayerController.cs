using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tennista.Model;

namespace Tennista.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private readonly ITennisRepository m_Repository;

        public PlayerController(ITennisRepository repository)
        {
            m_Repository = repository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return m_Repository.GetPlayers();
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
