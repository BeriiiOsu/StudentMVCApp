using StudentMVCApp.Controller;
using StudentMVCApp.Model;
namespace StudentMVCApp
{
    public partial class Form1 : Form
    {
        private readonly StudentController _studentController;
        public Form1()
        {
            InitializeComponent();
            _studentController = new StudentController(new StudentRepository());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = DateTime.Now.Millisecond,
                FullName = txtName.Text,
                Age = int.TryParse(txtAge.Text, out int age) ? age : 0
            };
            string result = _studentController.AddStudent(student);
            MessageBox.Show(result);
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            var students = _studentController.GetAllStudents();
            foreach (var student in students)
                lstStudents.Items.Add($"{student.Id} - {student.FullName}, Age: {student.Age}");
        }
    }
}
