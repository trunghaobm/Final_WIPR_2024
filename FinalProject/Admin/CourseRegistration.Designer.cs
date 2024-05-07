namespace FinalProject.Admin
{
    partial class CourseRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsbSelectedCourse = new System.Windows.Forms.ListBox();
            this.lsbAvailableCourse = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.STUDENTID = new System.Windows.Forms.TextBox();
            this.B_REMOVE = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblAvailableCourse = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lsbSelectedCourse);
            this.panel1.Controls.Add(this.lsbAvailableCourse);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbbSemester);
            this.panel1.Controls.Add(this.STUDENTID);
            this.panel1.Controls.Add(this.B_REMOVE);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblSelectedCourse);
            this.panel1.Controls.Add(this.lblAvailableCourse);
            this.panel1.Controls.Add(this.lblSemester);
            this.panel1.Controls.Add(this.lblStudentID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 439);
            this.panel1.TabIndex = 0;
            // 
            // lsbSelectedCourse
            // 
            this.lsbSelectedCourse.FormattingEnabled = true;
            this.lsbSelectedCourse.ItemHeight = 24;
            this.lsbSelectedCourse.Location = new System.Drawing.Point(377, 147);
            this.lsbSelectedCourse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbSelectedCourse.Name = "lsbSelectedCourse";
            this.lsbSelectedCourse.Size = new System.Drawing.Size(195, 196);
            this.lsbSelectedCourse.TabIndex = 19;
            this.lsbSelectedCourse.SelectedIndexChanged += new System.EventHandler(this.lsbSelectedCourse_SelectedIndexChanged);
            // 
            // lsbAvailableCourse
            // 
            this.lsbAvailableCourse.FormattingEnabled = true;
            this.lsbAvailableCourse.ItemHeight = 24;
            this.lsbAvailableCourse.Location = new System.Drawing.Point(52, 147);
            this.lsbAvailableCourse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAvailableCourse.Name = "lsbAvailableCourse";
            this.lsbAvailableCourse.Size = new System.Drawing.Size(195, 196);
            this.lsbAvailableCourse.TabIndex = 18;
            this.lsbAvailableCourse.SelectedIndexChanged += new System.EventHandler(this.lsbAvailableCourse_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(278, 281);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbSemester
            // 
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(451, 64);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(105, 32);
            this.cbbSemester.TabIndex = 12;
            // 
            // STUDENTID
            // 
            this.STUDENTID.Enabled = false;
            this.STUDENTID.Location = new System.Drawing.Point(139, 64);
            this.STUDENTID.Margin = new System.Windows.Forms.Padding(2);
            this.STUDENTID.Name = "STUDENTID";
            this.STUDENTID.Size = new System.Drawing.Size(174, 29);
            this.STUDENTID.TabIndex = 11;
            // 
            // B_REMOVE
            // 
            this.B_REMOVE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.B_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_REMOVE.ForeColor = System.Drawing.Color.White;
            this.B_REMOVE.Location = new System.Drawing.Point(278, 224);
            this.B_REMOVE.Margin = new System.Windows.Forms.Padding(2);
            this.B_REMOVE.Name = "B_REMOVE";
            this.B_REMOVE.Size = new System.Drawing.Size(66, 37);
            this.B_REMOVE.TabIndex = 16;
            this.B_REMOVE.Text = "Remove";
            this.B_REMOVE.UseVisualStyleBackColor = false;
            this.B_REMOVE.Click += new System.EventHandler(this.B_REMOVE_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(278, 160);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCourse.Location = new System.Drawing.Point(456, 121);
            this.lblSelectedCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(132, 17);
            this.lblSelectedCourse.TabIndex = 15;
            this.lblSelectedCourse.Text = "Selected Course:";
            // 
            // lblAvailableCourse
            // 
            this.lblAvailableCourse.AutoSize = true;
            this.lblAvailableCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourse.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCourse.Location = new System.Drawing.Point(49, 121);
            this.lblAvailableCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableCourse.Name = "lblAvailableCourse";
            this.lblAvailableCourse.Size = new System.Drawing.Size(135, 17);
            this.lblAvailableCourse.TabIndex = 13;
            this.lblAvailableCourse.Text = "Available Course:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(366, 64);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(81, 17);
            this.lblSemester.TabIndex = 14;
            this.lblSemester.Text = "Semester:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(49, 67);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(89, 17);
            this.lblStudentID.TabIndex = 10;
            this.lblStudentID.Text = "Student ID:";
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 439);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CourseRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseRegistration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsbSelectedCourse;
        private System.Windows.Forms.ListBox lsbAvailableCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.TextBox STUDENTID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblAvailableCourse;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button B_REMOVE;
    }
}