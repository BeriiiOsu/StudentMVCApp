using StudentMVCApp.Controller;

namespace StudentMVCApp.View
{
    public partial class MainForm : Form
    {
        // Global student controller and repository instances
        private readonly StudentController globalStudentController;
        private readonly StudentRepository globalStudentRepository;

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.globalStudentRepository = new StudentRepository();
            this.globalStudentController = new StudentController(globalStudentRepository);
        }
        private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 studentForm = new Form1(globalStudentController);
            studentForm.MdiParent = this;
            studentForm.Show();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) { Application.Exit(); }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.MdiParent = this;
            searchForm.Show();
        }
    }
}
