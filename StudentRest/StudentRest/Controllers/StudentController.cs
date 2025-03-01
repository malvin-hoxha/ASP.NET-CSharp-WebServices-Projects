using Microsoft.AspNetCore.Mvc;
using StudentRest.Models;
using StudentRest.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private IStudent _StudentRepo;


        public StudentController(IStudent studentRepo)
        {
            _StudentRepo = studentRepo;
            // _BookRepo = new InMemBookRepo();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return _StudentRepo.GetStudents().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(Guid id)
        {
            var student = _StudentRepo.GetStudent(id);
            if (student == null)
                return NotFound();
            return student;
        }

        // POST api/Books
        [HttpPost]
        public ActionResult CreateStudent(CreateOrUpdateStudentSchema student)
        {
            var mystudent = new Student();
            mystudent.StudentID = Guid.NewGuid();
            mystudent.Name = student.Name;
            mystudent.Email = student.Email;
            _StudentRepo.CreateStudent(mystudent);
            return Ok();
        }

        // PUT api/Books/5
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(Guid id, CreateOrUpdateStudentSchema student)
        {
            var mystudent = _StudentRepo.GetStudent(id);
            if (mystudent == null)
                return NotFound();
            mystudent.Name = student.Name;
            mystudent.Email = student.Email;
            _StudentRepo.UpdateStudent(id, mystudent);
            return Ok();
        }

        // DELETE api/Books/5
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(Guid id)
        {
            var mystudent = _StudentRepo.GetStudent(id);
            if (mystudent == null)
                return NotFound();
            _StudentRepo.DeleteStudent(id);
            return Ok();
        }


    }
}
