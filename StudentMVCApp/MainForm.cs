namespace StudentMVCApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 studentForm = new Form1();
            studentForm.MdiParent = this;
            studentForm.Show();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}