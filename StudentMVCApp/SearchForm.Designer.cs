namespace StudentMVCApp.View
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lst_results = new ListBox();
            field_student_name = new TextBox();
            btn_search = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lst_results
            // 
            lst_results.FormattingEnabled = true;
            lst_results.Location = new Point(12, 112);
            lst_results.Name = "lst_results";
            lst_results.Size = new Size(422, 304);
            lst_results.TabIndex = 0;
            // 
            // field_student_name
            // 
            field_student_name.Location = new Point(12, 64);
            field_student_name.Name = "field_student_name";
            field_student_name.Size = new Size(266, 27);
            field_student_name.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(284, 64);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(150, 29);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter student name:";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 429);
            Controls.Add(label1);
            Controls.Add(btn_search);
            Controls.Add(field_student_name);
            Controls.Add(lst_results);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_results;
        private TextBox field_student_name;
        private Button btn_search;
        private Label label1;
    }
}