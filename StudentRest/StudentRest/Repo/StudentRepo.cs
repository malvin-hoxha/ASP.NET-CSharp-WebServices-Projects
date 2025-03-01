using StudentRest.Models;

namespace StudentRest.Repo
{
    public class StudentRepo : IStudent
    {
        private List<Student> _Students;

        public StudentRepo()
        {
            // καταχώριση ενός πρώτου βιβλίου
            _Students = new() { new Student
             { StudentID=Guid.NewGuid(), Name="Marcus Aurelius", Email="marcusaurelius@gmail.com"}
             };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _Students;
        }

        public Student GetStudent(Guid id)
        {
            var student = _Students.Where(x => x.StudentID == id).SingleOrDefault();
            return student;
        }


        public void CreateStudent(Student student)
        {
            _Students.Add(student);
        }


        public void UpdateStudent(Guid id, Student student)
        {
            var studentindex = _Students.FindIndex(x => x.StudentID == id);
            if (studentindex > -1)
                _Students[studentindex] = student;
        }


        public void DeleteStudent(Guid id)
        {
            var studentindex = _Students.FindIndex(x => x.StudentID == id);
            if (studentindex > -1)
                _Students.RemoveAt(studentindex);
        }



    }
}
