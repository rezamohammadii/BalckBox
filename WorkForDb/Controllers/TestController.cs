using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkForDb.Database.Context;
using WorkForDb.Database.Entity;

namespace WorkForDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly MariaDbContext db;
        public TestController(MariaDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getmaxid = db.FieldStudies.LastOrDefault();
            Student st = new Student
            {
                Age = 18,
                Family = "mohammadi",
                Name = "reza"
            };
            
            db.Students.Add(st);
            db.SaveChanges();

            return Ok(st);
        }
    }
}
