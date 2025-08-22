using StudentMVCApp.Model;
namespace StudentMVCApp.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _repository;

        public StudentController(StudentRepository studentRepository) { _repository = studentRepository; }   

        public string AddStudent(Student student)
        {
            if (student == null)
                return "Student cannot be null.";
            try
            {
                if (string.IsNullOrWhiteSpace(student.FullName))
                    return "Full Name is required.";

                if (student.Age <= 0)
                    return "Age must be greater than zero.";

                _repository.AddStudent(student);
                return "Student added successfully.";
            }
            catch (Exception ex) { return $"Error adding student: {ex.Message}"; }
        }

        public List<Student> GetAllStudents()
        {
            try { return _repository.GetAllStudents(); }
            catch {  return new List<Student>(); }
        }

        public string EditStudent(Student student, int id)
        {
            if(string.IsNullOrWhiteSpace(student?.FullName))
                return "Full Name is required.";

            if (student.Age <= 0)
                return "Age must be greater than zero.";

            return _repository.EditStudent(student, id);
        }
    }
}
