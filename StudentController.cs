using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practi5.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> Students = new List<Student>();
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return Students;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return Students.FirstOrDefault(s => s.id == id);
        }

        // POST: api/Student
        public void Post([FromBody]Student value)
        {
            Students.Add(value);
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]Student value)
        {
            int i = Students.FindIndex(s => s.id == id);
            if (i >= 0)
                Students[i] = value;
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
            Students.RemoveAll(s => s.id == id);
        }
    }
}
