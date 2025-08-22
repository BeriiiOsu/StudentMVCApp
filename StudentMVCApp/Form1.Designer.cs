namespace StudentMVCApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            lstStudents = new ListBox();
            label2 = new Label();
            txtAge = new TextBox();
            btnViewAll = new Button();
            txtSearch = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            cbEditMode = new CheckBox();
            txtId = new TextBox();
            lblId = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstStudents
            // 
            lstStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(12, 165);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(453, 244);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 71);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(61, 23);
            txtAge.TabIndex = 1;
            // 
            // btnViewAll
            // 
            btnViewAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViewAll.Location = new Point(391, 415);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(75, 23);
            btnViewAll.TabIndex = 3;
            btnViewAll.Text = "View All ";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(284, 136);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search student here";
            txtSearch.Size = new Size(181, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(93, 100);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 38);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(174, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbEditMode
            // 
            cbEditMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbEditMode.AutoSize = true;
            cbEditMode.Location = new Point(12, 418);
            cbEditMode.Name = "cbEditMode";
            cbEditMode.Size = new Size(80, 19);
            cbEditMode.TabIndex = 8;
            cbEditMode.Text = "Edit mode";
            cbEditMode.UseVisualStyleBackColor = true;
            cbEditMode.CheckedChanged += cbEditMode_CheckedChanged;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(93, 71);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Enabled = false;
            lblId.Location = new Point(93, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 10;
            lblId.Text = "ID";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(cbEditMode);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(btnViewAll);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(lstStudents);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Button btnAdd;
        private ListBox lstStudents;
        private Label label2;
        private TextBox txtAge;
        private Button btnViewAll;
        private TextBox txtSearch;
        private Button btnEdit;
        private Button btnDelete;
        private CheckBox cbEditMode;
        private TextBox txtId;
        private Label lblId;
    }
}
