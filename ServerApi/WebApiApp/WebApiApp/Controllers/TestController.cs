using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
         static List<String> strList= new List<String>();
        public static int counter = 0;

        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            counter++;
            strList.Add("Value = " + counter);

            
            return strList.ToArray();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
