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

        //public string EditStudent(int id, Student updatedStudent)
        //{
        //    if (updatedStudent == null)
        //        return "Updated student cannot be null.";
        //    try
        //    {
        //        var students = _repository.GetAllStudents();
        //        var student = students.FirstOrDefault(s => s.Id == id);
        //        if (student == null)
        //            return "Student not found.";
        //        student.FullName = updatedStudent.FullName;
        //        student.Age = updatedStudent.Age;
        //        return "Student updated successfully.";
        //    }
        //    catch (Exception ex) { return $"Error updating student: {ex.Message}"; }
        //}
    }
}
