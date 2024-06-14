using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>();

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(i => i.Id == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            var row = students.FindIndex(i => i.Id == id);
            if(row >= 0)
                students[row] = value;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(i => i.Id == id);
        }
    }
}
