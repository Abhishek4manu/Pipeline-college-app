using CollegeApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudentName()
        {
            return Ok ( Collegerepository.GetAllStudents);
          


            

        }
        [HttpGet("{id:int}")]
        public ActionResult <Student> GetStudentNamebyId(int id)
        {
            if (id <= 0)
                return BadRequest();
            var stud = Collegerepository.GetAllStudents.Where(n => n.id == id).FirstOrDefault();
            if (stud==null)
            {
                return NotFound($"Student with id:{id} not found");
            }
            return Ok (stud);





        }
        [HttpGet("{name}")]
        public ActionResult<Student> GetStudentbyName(string name)
        {
            var stud= Collegerepository.GetAllStudents.Where(n => n.StudentName == name).FirstOrDefault();
            if ( stud==null)
            {
                return NotFound($"Student with name:{name} not found");
            }

            return Ok(stud);
        }

        [HttpDelete("{id:int}")]

        public ActionResult< bool > DeleteStudentbyId(int id)
        {
            var stud = Collegerepository.GetAllStudents.Where(n => n.id == id).FirstOrDefault();
            if (stud==null)
            {
                return NotFound($"Student with id:{id} not found");
            }
            Collegerepository.GetAllStudents.Remove(stud);
            return Ok(true);

        }
    }
}
