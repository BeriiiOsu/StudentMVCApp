using StudentMVCApp.Controller;
using StudentMVCApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMVCApp.View
{
    public partial class SearchForm : Form
    {
        private readonly StudentController _studentController;

        public SearchForm(StudentController parentStudentController)
        {
            InitializeComponent();
            this._studentController = parentStudentController;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string nameToSearch = field_student_name.Text.Trim();
            if (string.IsNullOrWhiteSpace(nameToSearch))
            {
                lst_results.Items.Add("Please enter a valid name to search.");
            }
            else
            {
                List<Student> searchedStudents = _studentController.SearchStudent(nameToSearch);
                if (searchedStudents.Count == 0)
                {
                    lst_results.Items.Add("No students found with the given name.");
                }
                else
                {
                    lst_results.Items.Clear();
                    foreach (var student in searchedStudents)
                    {
                        lst_results.Items.Add($"{student.Id} - {student.FullName}, Age: {student.Age}");
                    }
                }
            }
        }
    }
}
