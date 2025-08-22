using StudentMVCApp.Controller;
using StudentMVCApp.Model;
using System.Windows.Forms;
namespace StudentMVCApp
{
    public partial class Form1 : Form
    {
        private bool _isEditMode = false;
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
            ResetFields();
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            var students = _studentController.GetAllStudents();
            foreach (var student in students)
                lstStudents.Items.Add($"{student.Id} - {student.FullName}, Age: {student.Age}");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            List<Student> searchList = _studentController.GetAllStudents();
            searchList.ForEach(student =>
            {
                //ignore case while searching
                if (student.FullName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    lstStudents.Items.Add($"{student.Id} - {student.FullName}, Age: {student.Age}");
            });
        }
        private void ResetFields()
        {
            txtName.Clear();
            txtAge.Clear();
            txtId.Clear();
            txtName.Focus();
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this gets the selected student details from the list box
            txtName.Text = lstStudents.SelectedItem?.ToString().Split('-')[1].Split(',')[0].Trim();
            txtAge.Text = lstStudents.SelectedItem?.ToString().Split(':')[1].Trim();
            txtId.Text = lstStudents.SelectedItem?.ToString().Split('-')[0].Trim();
            CheckMode();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = int.Parse(txtId.Text),
                FullName = txtName.Text,
                Age = int.TryParse(txtAge.Text, out int age) ? age : 0
            };
            string result = _studentController.EditStudent(student, int.Parse(txtId.Text));
            MessageBox.Show(result);
            btnViewAll.PerformClick();
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            _isEditMode = cbEditMode.Checked;
            CheckMode();
        }

        private void CheckMode()
        {
            //this avoids student duplication
            if (_isEditMode)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                lblId.Enabled = true;
                txtId.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                lblId.Enabled = false;
                txtId.Enabled = false;
                btnDelete.Enabled = false;
                ResetFields();
            }
        }
    }
}