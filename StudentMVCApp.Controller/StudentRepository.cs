using StudentMVCApp.Model;
namespace StudentMVCApp.Controller
{
    public class StudentRepository
    {
        private List<Student> _students = new List<Student>();
        public void AddStudent(Student student) { _students.Add(student); }
        public string EditStudent(Student updatedStudent, int id)
        {
            Student studentToEdit = _students.Find(s => s.Id == id);
            if (studentToEdit != null)
            {
                studentToEdit.FullName = updatedStudent.FullName;
                studentToEdit.Age = updatedStudent.Age;
                return "Student updated successfully.";
            }
            return "Student not found.";
        }
        public List<Student> GetAllStudents() { return _students; }
        public string DeleteStudent(int id)
        {
            Student studentToDelete = _students.Find(s => s.Id == id);
            if (studentToDelete != null)
            {
                _students.Remove(studentToDelete);
                return "Student deleted successfully.";
            }
            return "Student not found.";
        }
    }
}