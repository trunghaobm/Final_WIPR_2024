namespace FinalProject.Lecturer
{
    partial class Information
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
            this.BIRTHDAY = new System.Windows.Forms.DateTimePicker();
            this.GENDER = new System.Windows.Forms.ComboBox();
            this.L_ADDRESS = new System.Windows.Forms.Label();
            this.L_AVATAR = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.FACTORY = new System.Windows.Forms.TextBox();
            this.L_EMAIL = new System.Windows.Forms.Label();
            this.L_GENDER = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.FIRSTNAME = new System.Windows.Forms.TextBox();
            this.L_FACTORY = new System.Windows.Forms.Label();
            this.LASTNAME = new System.Windows.Forms.TextBox();
            this.L_LASTNAME = new System.Windows.Forms.Label();
            this.L_FIRSTNAME = new System.Windows.Forms.Label();
            this.L_PHONE = new System.Windows.Forms.Label();
            this.B_REGISTER = new System.Windows.Forms.Button();
            this.L_BIRTHDAY = new System.Windows.Forms.Label();
            this.AVATAR = new System.Windows.Forms.PictureBox();
            this.P_DATA = new System.Windows.Forms.Panel();
            this.B_CHANGEPASSWORD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AVATAR)).BeginInit();
            this.P_DATA.SuspendLayout();
            this.SuspendLayout();
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.CustomFormat = "dd/MM/yyyy";
            this.BIRTHDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIRTHDAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BIRTHDAY.Location = new System.Drawing.Point(343, 144);
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.Size = new System.Drawing.Size(400, 35);
            this.BIRTHDAY.TabIndex = 3;
            // 
            // GENDER
            // 
            this.GENDER.FormattingEnabled = true;
            this.GENDER.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GENDER.Location = new System.Drawing.Point(343, 186);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(400, 32);
            this.GENDER.TabIndex = 4;
            this.GENDER.Text = "Chọn";
            // 
            // L_ADDRESS
            // 
            this.L_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ADDRESS.Location = new System.Drawing.Point(12, 320);
            this.L_ADDRESS.Name = "L_ADDRESS";
            this.L_ADDRESS.Size = new System.Drawing.Size(315, 38);
            this.L_ADDRESS.TabIndex = 14;
            this.L_ADDRESS.Text = "Địa chỉ";
            this.L_ADDRESS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_AVATAR
            // 
            this.L_AVATAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AVATAR.Location = new System.Drawing.Point(12, 364);
            this.L_AVATAR.Name = "L_AVATAR";
            this.L_AVATAR.Size = new System.Drawing.Size(315, 38);
            this.L_AVATAR.TabIndex = 23;
            this.L_AVATAR.Text = "Ảnh đại diện";
            this.L_AVATAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS.Location = new System.Drawing.Point(343, 320);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(400, 38);
            this.ADDRESS.TabIndex = 7;
            // 
            // PHONE
            // 
            this.PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE.Location = new System.Drawing.Point(343, 276);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(400, 38);
            this.PHONE.TabIndex = 6;
            // 
            // FACTORY
            // 
            this.FACTORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FACTORY.Location = new System.Drawing.Point(343, 12);
            this.FACTORY.Name = "FACTORY";
            this.FACTORY.Size = new System.Drawing.Size(400, 38);
            this.FACTORY.TabIndex = 0;
            // 
            // L_EMAIL
            // 
            this.L_EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EMAIL.Location = new System.Drawing.Point(12, 232);
            this.L_EMAIL.Name = "L_EMAIL";
            this.L_EMAIL.Size = new System.Drawing.Size(315, 38);
            this.L_EMAIL.TabIndex = 10;
            this.L_EMAIL.Text = "Email";
            this.L_EMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_GENDER
            // 
            this.L_GENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_GENDER.Location = new System.Drawing.Point(12, 188);
            this.L_GENDER.Name = "L_GENDER";
            this.L_GENDER.Size = new System.Drawing.Size(315, 38);
            this.L_GENDER.TabIndex = 11;
            this.L_GENDER.Text = "Giới tính";
            this.L_GENDER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EMAIL
            // 
            this.EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.Location = new System.Drawing.Point(343, 232);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(400, 38);
            this.EMAIL.TabIndex = 5;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRSTNAME.Location = new System.Drawing.Point(343, 56);
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.Size = new System.Drawing.Size(400, 38);
            this.FIRSTNAME.TabIndex = 1;
            this.FIRSTNAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // L_FACTORY
            // 
            this.L_FACTORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FACTORY.Location = new System.Drawing.Point(12, 12);
            this.L_FACTORY.Name = "L_FACTORY";
            this.L_FACTORY.Size = new System.Drawing.Size(315, 38);
            this.L_FACTORY.TabIndex = 7;
            this.L_FACTORY.Text = "Khoa";
            this.L_FACTORY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LASTNAME
            // 
            this.LASTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LASTNAME.Location = new System.Drawing.Point(343, 100);
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.Size = new System.Drawing.Size(400, 38);
            this.LASTNAME.TabIndex = 2;
            this.LASTNAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // L_LASTNAME
            // 
            this.L_LASTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LASTNAME.Location = new System.Drawing.Point(12, 100);
            this.L_LASTNAME.Name = "L_LASTNAME";
            this.L_LASTNAME.Size = new System.Drawing.Size(315, 38);
            this.L_LASTNAME.TabIndex = 2;
            this.L_LASTNAME.Text = "Tên";
            this.L_LASTNAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_FIRSTNAME
            // 
            this.L_FIRSTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FIRSTNAME.Location = new System.Drawing.Point(12, 56);
            this.L_FIRSTNAME.Name = "L_FIRSTNAME";
            this.L_FIRSTNAME.Size = new System.Drawing.Size(315, 38);
            this.L_FIRSTNAME.TabIndex = 6;
            this.L_FIRSTNAME.Text = "Họ và Tên đệm";
            this.L_FIRSTNAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_PHONE
            // 
            this.L_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PHONE.Location = new System.Drawing.Point(12, 276);
            this.L_PHONE.Name = "L_PHONE";
            this.L_PHONE.Size = new System.Drawing.Size(315, 38);
            this.L_PHONE.TabIndex = 15;
            this.L_PHONE.Text = "Số điện thoại";
            this.L_PHONE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // B_REGISTER
            // 
            this.B_REGISTER.Location = new System.Drawing.Point(569, 641);
            this.B_REGISTER.Margin = new System.Windows.Forms.Padding(6);
            this.B_REGISTER.Name = "B_REGISTER";
            this.B_REGISTER.Size = new System.Drawing.Size(174, 53);
            this.B_REGISTER.TabIndex = 10;
            this.B_REGISTER.Text = "Cập nhật";
            this.B_REGISTER.UseVisualStyleBackColor = true;
            this.B_REGISTER.Click += new System.EventHandler(this.B_CONFIRM_EDIT_Click);
            // 
            // L_BIRTHDAY
            // 
            this.L_BIRTHDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_BIRTHDAY.Location = new System.Drawing.Point(12, 144);
            this.L_BIRTHDAY.Name = "L_BIRTHDAY";
            this.L_BIRTHDAY.Size = new System.Drawing.Size(315, 38);
            this.L_BIRTHDAY.TabIndex = 2;
            this.L_BIRTHDAY.Text = "Ngày sinh";
            this.L_BIRTHDAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AVATAR
            // 
            this.AVATAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AVATAR.Location = new System.Drawing.Point(343, 365);
            this.AVATAR.Name = "AVATAR";
            this.AVATAR.Size = new System.Drawing.Size(179, 179);
            this.AVATAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AVATAR.TabIndex = 24;
            this.AVATAR.TabStop = false;
            this.AVATAR.Click += new System.EventHandler(this.AVATAR_Click);
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.BIRTHDAY);
            this.P_DATA.Controls.Add(this.GENDER);
            this.P_DATA.Controls.Add(this.L_ADDRESS);
            this.P_DATA.Controls.Add(this.L_AVATAR);
            this.P_DATA.Controls.Add(this.ADDRESS);
            this.P_DATA.Controls.Add(this.PHONE);
            this.P_DATA.Controls.Add(this.FACTORY);
            this.P_DATA.Controls.Add(this.L_EMAIL);
            this.P_DATA.Controls.Add(this.L_GENDER);
            this.P_DATA.Controls.Add(this.EMAIL);
            this.P_DATA.Controls.Add(this.FIRSTNAME);
            this.P_DATA.Controls.Add(this.L_FACTORY);
            this.P_DATA.Controls.Add(this.LASTNAME);
            this.P_DATA.Controls.Add(this.L_LASTNAME);
            this.P_DATA.Controls.Add(this.L_FIRSTNAME);
            this.P_DATA.Controls.Add(this.L_PHONE);
            this.P_DATA.Controls.Add(this.B_CHANGEPASSWORD);
            this.P_DATA.Controls.Add(this.B_REGISTER);
            this.P_DATA.Controls.Add(this.L_BIRTHDAY);
            this.P_DATA.Controls.Add(this.AVATAR);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 0);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(867, 717);
            this.P_DATA.TabIndex = 26;
            // 
            // B_CHANGEPASSWORD
            // 
            this.B_CHANGEPASSWORD.Location = new System.Drawing.Point(343, 641);
            this.B_CHANGEPASSWORD.Margin = new System.Windows.Forms.Padding(6);
            this.B_CHANGEPASSWORD.Name = "B_CHANGEPASSWORD";
            this.B_CHANGEPASSWORD.Size = new System.Drawing.Size(174, 53);
            this.B_CHANGEPASSWORD.TabIndex = 10;
            this.B_CHANGEPASSWORD.TabStop = false;
            this.B_CHANGEPASSWORD.Text = "Đổi mật khẩu";
            this.B_CHANGEPASSWORD.UseVisualStyleBackColor = true;
            this.B_CHANGEPASSWORD.Click += new System.EventHandler(this.B_CHANGPASSWORD_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 717);
            this.Controls.Add(this.P_DATA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Information";
            this.Text = "LecturerManager";
            ((System.ComponentModel.ISupportInitialize)(this.AVATAR)).EndInit();
            this.P_DATA.ResumeLayout(false);
            this.P_DATA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BIRTHDAY;
        private System.Windows.Forms.ComboBox GENDER;
        private System.Windows.Forms.Label L_ADDRESS;
        private System.Windows.Forms.Label L_AVATAR;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.TextBox FACTORY;
        private System.Windows.Forms.Label L_EMAIL;
        private System.Windows.Forms.Label L_GENDER;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox FIRSTNAME;
        private System.Windows.Forms.Label L_FACTORY;
        private System.Windows.Forms.TextBox LASTNAME;
        private System.Windows.Forms.Label L_LASTNAME;
        private System.Windows.Forms.Label L_FIRSTNAME;
        private System.Windows.Forms.Label L_PHONE;
        private System.Windows.Forms.Button B_REGISTER;
        private System.Windows.Forms.Label L_BIRTHDAY;
        private System.Windows.Forms.PictureBox AVATAR;
        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.Button B_CHANGEPASSWORD;
    }
}