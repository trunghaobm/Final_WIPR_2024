namespace FinalProject.Login
{
    partial class Login
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
            this.B_LOGIN = new System.Windows.Forms.Button();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_REMEMBER = new System.Windows.Forms.CheckBox();
            this.P_PERMISSION = new System.Windows.Forms.Panel();
            this.R_STUDENT = new System.Windows.Forms.RadioButton();
            this.R_LECTURER = new System.Windows.Forms.RadioButton();
            this.R_ADMIN = new System.Windows.Forms.RadioButton();
            this.B_CANCLE = new System.Windows.Forms.Button();
            this.B_REGISTER = new System.Windows.Forms.Label();
            this.L_FORGOTPASS = new System.Windows.Forms.Label();
            this.B_CLOSE = new System.Windows.Forms.Button();
            this.P_PERMISSION.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_LOGIN
            // 
            this.B_LOGIN.Location = new System.Drawing.Point(163, 247);
            this.B_LOGIN.Margin = new System.Windows.Forms.Padding(6);
            this.B_LOGIN.Name = "B_LOGIN";
            this.B_LOGIN.Size = new System.Drawing.Size(267, 53);
            this.B_LOGIN.TabIndex = 2;
            this.B_LOGIN.Text = "Đăng nhập";
            this.B_LOGIN.UseVisualStyleBackColor = true;
            this.B_LOGIN.Click += new System.EventHandler(this.B_LOGIN_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.Location = new System.Drawing.Point(163, 106);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(267, 38);
            this.EMAIL.TabIndex = 0;
            this.EMAIL.Text = "haoden2@gmail.com";
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(163, 169);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(267, 38);
            this.PASSWORD.TabIndex = 1;
            this.PASSWORD.Text = "Admin@123";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_REMEMBER
            // 
            this.CB_REMEMBER.AutoSize = true;
            this.CB_REMEMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_REMEMBER.Location = new System.Drawing.Point(163, 214);
            this.CB_REMEMBER.Name = "CB_REMEMBER";
            this.CB_REMEMBER.Size = new System.Drawing.Size(138, 20);
            this.CB_REMEMBER.TabIndex = 3;
            this.CB_REMEMBER.Text = "Ghi nhớ đăng nhập";
            this.CB_REMEMBER.UseVisualStyleBackColor = true;
            // 
            // P_PERMISSION
            // 
            this.P_PERMISSION.Controls.Add(this.R_STUDENT);
            this.P_PERMISSION.Controls.Add(this.R_LECTURER);
            this.P_PERMISSION.Controls.Add(this.R_ADMIN);
            this.P_PERMISSION.Location = new System.Drawing.Point(163, 41);
            this.P_PERMISSION.Name = "P_PERMISSION";
            this.P_PERMISSION.Size = new System.Drawing.Size(267, 59);
            this.P_PERMISSION.TabIndex = 4;
            // 
            // R_STUDENT
            // 
            this.R_STUDENT.AutoSize = true;
            this.R_STUDENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_STUDENT.Location = new System.Drawing.Point(174, 19);
            this.R_STUDENT.Name = "R_STUDENT";
            this.R_STUDENT.Size = new System.Drawing.Size(81, 20);
            this.R_STUDENT.TabIndex = 0;
            this.R_STUDENT.Text = "Sinh Viên";
            this.R_STUDENT.UseVisualStyleBackColor = true;
            this.R_STUDENT.CheckedChanged += new System.EventHandler(this.R_STUDENT_CheckedChanged);
            // 
            // R_LECTURER
            // 
            this.R_LECTURER.AutoSize = true;
            this.R_LECTURER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_LECTURER.Location = new System.Drawing.Point(84, 19);
            this.R_LECTURER.Name = "R_LECTURER";
            this.R_LECTURER.Size = new System.Drawing.Size(84, 20);
            this.R_LECTURER.TabIndex = 0;
            this.R_LECTURER.Text = "Giáo Viên";
            this.R_LECTURER.UseVisualStyleBackColor = true;
            this.R_LECTURER.CheckedChanged += new System.EventHandler(this.R_LECTURER_CheckedChanged);
            // 
            // R_ADMIN
            // 
            this.R_ADMIN.AutoSize = true;
            this.R_ADMIN.Checked = true;
            this.R_ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_ADMIN.Location = new System.Drawing.Point(15, 19);
            this.R_ADMIN.Name = "R_ADMIN";
            this.R_ADMIN.Size = new System.Drawing.Size(63, 20);
            this.R_ADMIN.TabIndex = 0;
            this.R_ADMIN.TabStop = true;
            this.R_ADMIN.Text = "Admin";
            this.R_ADMIN.UseVisualStyleBackColor = true;
            this.R_ADMIN.CheckedChanged += new System.EventHandler(this.R_ADMIN_CheckedChanged);
            // 
            // B_CANCLE
            // 
            this.B_CANCLE.Location = new System.Drawing.Point(160, 312);
            this.B_CANCLE.Margin = new System.Windows.Forms.Padding(6);
            this.B_CANCLE.Name = "B_CANCLE";
            this.B_CANCLE.Size = new System.Drawing.Size(270, 53);
            this.B_CANCLE.TabIndex = 2;
            this.B_CANCLE.Text = "Hủy";
            this.B_CANCLE.UseVisualStyleBackColor = true;
            this.B_CANCLE.Click += new System.EventHandler(this.B_CANCLE_Click);
            // 
            // B_REGISTER
            // 
            this.B_REGISTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_REGISTER.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_REGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_REGISTER.ForeColor = System.Drawing.Color.Blue;
            this.B_REGISTER.Location = new System.Drawing.Point(0, 564);
            this.B_REGISTER.Name = "B_REGISTER";
            this.B_REGISTER.Size = new System.Drawing.Size(529, 24);
            this.B_REGISTER.TabIndex = 5;
            this.B_REGISTER.Text = "Chưa có tài khoản? Đăng ký";
            this.B_REGISTER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_REGISTER.Click += new System.EventHandler(this.B_REGISTER_Click);
            // 
            // L_FORGOTPASS
            // 
            this.L_FORGOTPASS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_FORGOTPASS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.L_FORGOTPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FORGOTPASS.ForeColor = System.Drawing.Color.Blue;
            this.L_FORGOTPASS.Location = new System.Drawing.Point(0, 540);
            this.L_FORGOTPASS.Name = "L_FORGOTPASS";
            this.L_FORGOTPASS.Size = new System.Drawing.Size(529, 24);
            this.L_FORGOTPASS.TabIndex = 5;
            this.L_FORGOTPASS.Text = "Quên mật khẩu";
            this.L_FORGOTPASS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_FORGOTPASS.Click += new System.EventHandler(this.L_FORGOTPASS_Click);
            // 
            // B_CLOSE
            // 
            this.B_CLOSE.BackColor = System.Drawing.Color.Red;
            this.B_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CLOSE.Location = new System.Drawing.Point(504, 1);
            this.B_CLOSE.Name = "B_CLOSE";
            this.B_CLOSE.Size = new System.Drawing.Size(25, 25);
            this.B_CLOSE.TabIndex = 6;
            this.B_CLOSE.UseVisualStyleBackColor = false;
            this.B_CLOSE.Click += new System.EventHandler(this.B_CLOSE_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(529, 588);
            this.Controls.Add(this.B_CLOSE);
            this.Controls.Add(this.L_FORGOTPASS);
            this.Controls.Add(this.B_REGISTER);
            this.Controls.Add(this.P_PERMISSION);
            this.Controls.Add(this.CB_REMEMBER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.B_CANCLE);
            this.Controls.Add(this.B_LOGIN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.P_PERMISSION.ResumeLayout(false);
            this.P_PERMISSION.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_LOGIN;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_REMEMBER;
        private System.Windows.Forms.Panel P_PERMISSION;
        private System.Windows.Forms.RadioButton R_STUDENT;
        private System.Windows.Forms.RadioButton R_LECTURER;
        private System.Windows.Forms.RadioButton R_ADMIN;
        private System.Windows.Forms.Button B_CANCLE;
        private System.Windows.Forms.Label B_REGISTER;
        private System.Windows.Forms.Label L_FORGOTPASS;
        private System.Windows.Forms.Button B_CLOSE;
    }
}