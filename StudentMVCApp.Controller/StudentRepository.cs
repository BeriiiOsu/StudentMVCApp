using StudentMVCApp.Model;
namespace StudentMVCApp.Controller
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new List<Student>();
        public void AddStudent(Student student) { _students.Add(student); }
        public List<Student> GetAllStudents() { return _students; }

        public List<Student> SearchStudentsByName(string name)
        {
            return _students
                .Where(s => s.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
    }
}