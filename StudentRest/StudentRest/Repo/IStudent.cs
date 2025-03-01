using StudentRest.Models;

namespace StudentRest.Repo
{
    public interface IStudent
    {
        public IEnumerable<Student> GetStudents();
        public Student GetStudent(Guid id);
        public void CreateStudent(Student student);
        public void UpdateStudent(Guid id, Student student);
        public void DeleteStudent(Guid id);

    }
}
