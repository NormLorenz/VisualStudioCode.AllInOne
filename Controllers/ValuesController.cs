using Microsoft.AspNet.Mvc;
using VisualStudioCode.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace VisualStudioCode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            System.Console.WriteLine("...GET api/values called");
            
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            System.Console.WriteLine(string.Format("...GET api/values/{0} called", id));
            
            return "value" + id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            System.Console.WriteLine("...POST api/values called");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            System.Console.WriteLine(string.Format("...PUT api/values/{0} called", id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(string.Format("...DELETE api/values/{0} called", id));
        }
    }
}
