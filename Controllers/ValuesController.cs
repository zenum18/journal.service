using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using journalapp.service.models;

namespace journal.service.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values/5
        [HttpGet]
        public string[] Get()
        {
            return new string[] {"id", "entry" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/values
        [HttpPost]
        [Route("/simplePost")]
        public IEnumerable<string> PostSimpleJsonBody([FromBody] SimplePostRequest SimplePostRequest)
        {
            SimplePostRequest requestBody = SimplePostRequest;
            DateTime entryCreated = DateTime.Now;
            return new string[] { requestBody.entryId, requestBody.entry, entryCreated.ToString() };
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
