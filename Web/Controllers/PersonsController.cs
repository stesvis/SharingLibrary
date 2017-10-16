using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shared_2;

namespace Web.Controllers
{
    public class PersonsController : ApiController
    {
        // GET: api/Persons
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Persons/5
        public IHttpActionResult Get(int id)
        {
            var person = new Person_2();

            return Ok(person);
        }

        // POST: api/Persons
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Persons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Persons/5
        public void Delete(int id)
        {
        }
    }
}