using BlackBox.Database.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackBox.Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly MyDbContext db;
        public TestController(MyDbContext db)
        {
            this.db = db;
        }
        // GET: api/<TestController>
        [HttpGet]
        public  IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using var tx = await db.Database.BeginTransactionAsync();
            var data = await db.Products.FindAsync(id);
            data.Name = "value";


            var data2 = await db.Products.FromSqlRaw("SELECT * FROM Products WITH (NOLOCK) WHERE ID = 1")
                    .FirstOrDefaultAsync();
                
                return Ok(data);
            
            
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
          
                
                return Ok();
            
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
