namespace FinalProject.Admin
{
    partial class StudentManager
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
            this.R_FEMALE = new System.Windows.Forms.RadioButton();
            this.R_MALE = new System.Windows.Forms.RadioButton();
            this.L_AVATAR = new System.Windows.Forms.Label();
            this.L_ADDRESS = new System.Windows.Forms.Label();
            this.P_MAIN = new System.Windows.Forms.Panel();
            this.DGV_LIST = new System.Windows.Forms.DataGridView();
            this.P_LIST_TOPMENU = new System.Windows.Forms.Panel();
            this.B_SEARCH = new System.Windows.Forms.Button();
            this.T_SEARCH = new System.Windows.Forms.TextBox();
            this.P_LIST_CONTROL = new System.Windows.Forms.Panel();
            this.B_OK_IMPORT = new System.Windows.Forms.Button();
            this.B_RELOAD = new System.Windows.Forms.Button();
            this.B_IMPORT = new System.Windows.Forms.Button();
            this.B_TOTAL = new System.Windows.Forms.Button();
            this.L_GENDER = new System.Windows.Forms.Label();
            this.L_PHONE = new System.Windows.Forms.Label();
            this.L_BIRTHDAY = new System.Windows.Forms.Label();
            this.L_LASTNAME = new System.Windows.Forms.Label();
            this.L_FIRSTNAME = new System.Windows.Forms.Label();
            this.L_MSSV = new System.Windows.Forms.Label();
            this.AVATAR = new System.Windows.Forms.PictureBox();
            this.ADDRESS = new System.Windows.Forms.RichTextBox();
            this.BIRTHDAY = new System.Windows.Forms.DateTimePicker();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.LASTNAME = new System.Windows.Forms.TextBox();
            this.FIRSTNAME = new System.Windows.Forms.TextBox();
            this.MSSV = new System.Windows.Forms.TextBox();
            this.P_INFORMATION = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_REMOVE = new System.Windows.Forms.Button();
            this.B_UPDATE = new System.Windows.Forms.Button();
            this.B_ADD = new System.Windows.Forms.Button();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.P_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LIST)).BeginInit();
            this.P_LIST_TOPMENU.SuspendLayout();
            this.P_LIST_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AVATAR)).BeginInit();
            this.P_INFORMATION.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // R_FEMALE
            // 
            this.R_FEMALE.AutoSize = true;
            this.R_FEMALE.Location = new System.Drawing.Point(250, 215);
            this.R_FEMALE.Name = "R_FEMALE";
            this.R_FEMALE.Size = new System.Drawing.Size(53, 28);
            this.R_FEMALE.TabIndex = 7;
            this.R_FEMALE.Text = "Nữ";
            this.R_FEMALE.UseVisualStyleBackColor = true;
            // 
            // R_MALE
            // 
            this.R_MALE.AutoSize = true;
            this.R_MALE.Checked = true;
            this.R_MALE.Location = new System.Drawing.Point(151, 215);
            this.R_MALE.Name = "R_MALE";
            this.R_MALE.Size = new System.Drawing.Size(68, 28);
            this.R_MALE.TabIndex = 6;
            this.R_MALE.TabStop = true;
            this.R_MALE.Text = "Nam";
            this.R_MALE.UseVisualStyleBackColor = true;
            // 
            // L_AVATAR
            // 
            this.L_AVATAR.Location = new System.Drawing.Point(11, 393);
            this.L_AVATAR.Name = "L_AVATAR";
            this.L_AVATAR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_AVATAR.Size = new System.Drawing.Size(131, 23);
            this.L_AVATAR.TabIndex = 5;
            this.L_AVATAR.Text = "Ảnh đại diện";
            this.L_AVATAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_ADDRESS
            // 
            this.L_ADDRESS.Location = new System.Drawing.Point(11, 259);
            this.L_ADDRESS.Name = "L_ADDRESS";
            this.L_ADDRESS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_ADDRESS.Size = new System.Drawing.Size(131, 23);
            this.L_ADDRESS.TabIndex = 5;
            this.L_ADDRESS.Text = "Địa chỉ";
            this.L_ADDRESS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P_MAIN
            // 
            this.P_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P_MAIN.Controls.Add(this.DGV_LIST);
            this.P_MAIN.Controls.Add(this.P_LIST_TOPMENU);
            this.P_MAIN.Controls.Add(this.P_LIST_CONTROL);
            this.P_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_MAIN.Location = new System.Drawing.Point(321, 0);
            this.P_MAIN.Name = "P_MAIN";
            this.P_MAIN.Size = new System.Drawing.Size(781, 712);
            this.P_MAIN.TabIndex = 5;
            // 
            // DGV_LIST
            // 
            this.DGV_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_LIST.Location = new System.Drawing.Point(0, 50);
            this.DGV_LIST.Name = "DGV_LIST";
            this.DGV_LIST.Size = new System.Drawing.Size(781, 559);
            this.DGV_LIST.TabIndex = 0;
            // 
            // P_LIST_TOPMENU
            // 
            this.P_LIST_TOPMENU.Controls.Add(this.B_SEARCH);
            this.P_LIST_TOPMENU.Controls.Add(this.T_SEARCH);
            this.P_LIST_TOPMENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_LIST_TOPMENU.Location = new System.Drawing.Point(0, 0);
            this.P_LIST_TOPMENU.Name = "P_LIST_TOPMENU";
            this.P_LIST_TOPMENU.Size = new System.Drawing.Size(781, 50);
            this.P_LIST_TOPMENU.TabIndex = 4;
            // 
            // B_SEARCH
            // 
            this.B_SEARCH.Location = new System.Drawing.Point(303, 2);
            this.B_SEARCH.Name = "B_SEARCH";
            this.B_SEARCH.Size = new System.Drawing.Size(111, 32);
            this.B_SEARCH.TabIndex = 2;
            this.B_SEARCH.Text = "Tìm kiếm";
            this.B_SEARCH.UseVisualStyleBackColor = true;
            // 
            // T_SEARCH
            // 
            this.T_SEARCH.Location = new System.Drawing.Point(7, 5);
            this.T_SEARCH.Name = "T_SEARCH";
            this.T_SEARCH.Size = new System.Drawing.Size(290, 29);
            this.T_SEARCH.TabIndex = 1;
            // 
            // P_LIST_CONTROL
            // 
            this.P_LIST_CONTROL.Controls.Add(this.B_OK_IMPORT);
            this.P_LIST_CONTROL.Controls.Add(this.B_RELOAD);
            this.P_LIST_CONTROL.Controls.Add(this.B_IMPORT);
            this.P_LIST_CONTROL.Controls.Add(this.B_TOTAL);
            this.P_LIST_CONTROL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_LIST_CONTROL.Location = new System.Drawing.Point(0, 609);
            this.P_LIST_CONTROL.Name = "P_LIST_CONTROL";
            this.P_LIST_CONTROL.Size = new System.Drawing.Size(781, 103);
            this.P_LIST_CONTROL.TabIndex = 3;
            // 
            // B_OK_IMPORT
            // 
            this.B_OK_IMPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_OK_IMPORT.Location = new System.Drawing.Point(478, 17);
            this.B_OK_IMPORT.Name = "B_OK_IMPORT";
            this.B_OK_IMPORT.Size = new System.Drawing.Size(93, 41);
            this.B_OK_IMPORT.TabIndex = 0;
            this.B_OK_IMPORT.TabStop = false;
            this.B_OK_IMPORT.Text = "OK";
            this.B_OK_IMPORT.UseVisualStyleBackColor = true;
            this.B_OK_IMPORT.Visible = false;
            this.B_OK_IMPORT.Click += new System.EventHandler(this.B_OK_IMPORT_Click);
            // 
            // B_RELOAD
            // 
            this.B_RELOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_RELOAD.Location = new System.Drawing.Point(676, 17);
            this.B_RELOAD.Name = "B_RELOAD";
            this.B_RELOAD.Size = new System.Drawing.Size(93, 41);
            this.B_RELOAD.TabIndex = 0;
            this.B_RELOAD.TabStop = false;
            this.B_RELOAD.Text = "Tải lại";
            this.B_RELOAD.UseVisualStyleBackColor = true;
            this.B_RELOAD.Click += new System.EventHandler(this.B_RELOAD_Click);
            // 
            // B_IMPORT
            // 
            this.B_IMPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_IMPORT.Location = new System.Drawing.Point(577, 17);
            this.B_IMPORT.Name = "B_IMPORT";
            this.B_IMPORT.Size = new System.Drawing.Size(93, 41);
            this.B_IMPORT.TabIndex = 0;
            this.B_IMPORT.TabStop = false;
            this.B_IMPORT.Text = "Import";
            this.B_IMPORT.UseVisualStyleBackColor = true;
            this.B_IMPORT.Click += new System.EventHandler(this.B_IMPORT_Click);
            // 
            // B_TOTAL
            // 
            this.B_TOTAL.Location = new System.Drawing.Point(7, 14);
            this.B_TOTAL.Name = "B_TOTAL";
            this.B_TOTAL.Size = new System.Drawing.Size(93, 41);
            this.B_TOTAL.TabIndex = 0;
            this.B_TOTAL.TabStop = false;
            this.B_TOTAL.Text = "Total";
            this.B_TOTAL.UseVisualStyleBackColor = true;
            // 
            // L_GENDER
            // 
            this.L_GENDER.Location = new System.Drawing.Point(14, 218);
            this.L_GENDER.Name = "L_GENDER";
            this.L_GENDER.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_GENDER.Size = new System.Drawing.Size(131, 23);
            this.L_GENDER.TabIndex = 5;
            this.L_GENDER.Text = "Giói tính";
            this.L_GENDER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_PHONE
            // 
            this.L_PHONE.Location = new System.Drawing.Point(14, 181);
            this.L_PHONE.Name = "L_PHONE";
            this.L_PHONE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_PHONE.Size = new System.Drawing.Size(131, 23);
            this.L_PHONE.TabIndex = 5;
            this.L_PHONE.Text = "Số điện thoại";
            this.L_PHONE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_BIRTHDAY
            // 
            this.L_BIRTHDAY.Location = new System.Drawing.Point(15, 113);
            this.L_BIRTHDAY.Name = "L_BIRTHDAY";
            this.L_BIRTHDAY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_BIRTHDAY.Size = new System.Drawing.Size(131, 23);
            this.L_BIRTHDAY.TabIndex = 5;
            this.L_BIRTHDAY.Text = "Ngày sinh";
            this.L_BIRTHDAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_LASTNAME
            // 
            this.L_LASTNAME.Location = new System.Drawing.Point(12, 79);
            this.L_LASTNAME.Name = "L_LASTNAME";
            this.L_LASTNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_LASTNAME.Size = new System.Drawing.Size(131, 23);
            this.L_LASTNAME.TabIndex = 5;
            this.L_LASTNAME.Text = "Tên";
            this.L_LASTNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_FIRSTNAME
            // 
            this.L_FIRSTNAME.Location = new System.Drawing.Point(12, 46);
            this.L_FIRSTNAME.Name = "L_FIRSTNAME";
            this.L_FIRSTNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_FIRSTNAME.Size = new System.Drawing.Size(131, 23);
            this.L_FIRSTNAME.TabIndex = 5;
            this.L_FIRSTNAME.Text = "Họ và tên đệm";
            this.L_FIRSTNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_MSSV
            // 
            this.L_MSSV.Location = new System.Drawing.Point(12, 7);
            this.L_MSSV.Name = "L_MSSV";
            this.L_MSSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_MSSV.Size = new System.Drawing.Size(131, 23);
            this.L_MSSV.TabIndex = 5;
            this.L_MSSV.Text = "MSSV";
            this.L_MSSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AVATAR
            // 
            this.AVATAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AVATAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AVATAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AVATAR.Location = new System.Drawing.Point(148, 393);
            this.AVATAR.Name = "AVATAR";
            this.AVATAR.Size = new System.Drawing.Size(166, 166);
            this.AVATAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AVATAR.TabIndex = 4;
            this.AVATAR.TabStop = false;
            this.AVATAR.Click += new System.EventHandler(this.AVATAR_Click);
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(148, 255);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(166, 132);
            this.ADDRESS.TabIndex = 8;
            this.ADDRESS.Text = "";
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.CustomFormat = "dd/MM/yyyy";
            this.BIRTHDAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BIRTHDAY.Location = new System.Drawing.Point(149, 107);
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.Size = new System.Drawing.Size(166, 29);
            this.BIRTHDAY.TabIndex = 3;
            // 
            // PHONE
            // 
            this.PHONE.Location = new System.Drawing.Point(148, 177);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(166, 29);
            this.PHONE.TabIndex = 5;
            // 
            // LASTNAME
            // 
            this.LASTNAME.Location = new System.Drawing.Point(149, 75);
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.Size = new System.Drawing.Size(166, 29);
            this.LASTNAME.TabIndex = 2;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.Location = new System.Drawing.Point(149, 40);
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.Size = new System.Drawing.Size(166, 29);
            this.FIRSTNAME.TabIndex = 1;
            // 
            // MSSV
            // 
            this.MSSV.Location = new System.Drawing.Point(149, 5);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(166, 29);
            this.MSSV.TabIndex = 0;
            this.MSSV.TextChanged += new System.EventHandler(this.MSSV_TextChanged);
            // 
            // P_INFORMATION
            // 
            this.P_INFORMATION.BackColor = System.Drawing.Color.Wheat;
            this.P_INFORMATION.Controls.Add(this.R_FEMALE);
            this.P_INFORMATION.Controls.Add(this.L_AVATAR);
            this.P_INFORMATION.Controls.Add(this.R_MALE);
            this.P_INFORMATION.Controls.Add(this.L_ADDRESS);
            this.P_INFORMATION.Controls.Add(this.panel1);
            this.P_INFORMATION.Controls.Add(this.EMAIL);
            this.P_INFORMATION.Controls.Add(this.PHONE);
            this.P_INFORMATION.Controls.Add(this.label1);
            this.P_INFORMATION.Controls.Add(this.L_GENDER);
            this.P_INFORMATION.Controls.Add(this.L_PHONE);
            this.P_INFORMATION.Controls.Add(this.L_BIRTHDAY);
            this.P_INFORMATION.Controls.Add(this.L_LASTNAME);
            this.P_INFORMATION.Controls.Add(this.L_FIRSTNAME);
            this.P_INFORMATION.Controls.Add(this.L_MSSV);
            this.P_INFORMATION.Controls.Add(this.AVATAR);
            this.P_INFORMATION.Controls.Add(this.ADDRESS);
            this.P_INFORMATION.Controls.Add(this.BIRTHDAY);
            this.P_INFORMATION.Controls.Add(this.LASTNAME);
            this.P_INFORMATION.Controls.Add(this.FIRSTNAME);
            this.P_INFORMATION.Controls.Add(this.MSSV);
            this.P_INFORMATION.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_INFORMATION.Location = new System.Drawing.Point(0, 0);
            this.P_INFORMATION.Name = "P_INFORMATION";
            this.P_INFORMATION.Size = new System.Drawing.Size(321, 712);
            this.P_INFORMATION.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.B_REMOVE);
            this.panel1.Controls.Add(this.B_UPDATE);
            this.panel1.Controls.Add(this.B_ADD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 106);
            this.panel1.TabIndex = 3;
            // 
            // B_REMOVE
            // 
            this.B_REMOVE.Location = new System.Drawing.Point(210, 29);
            this.B_REMOVE.Name = "B_REMOVE";
            this.B_REMOVE.Size = new System.Drawing.Size(93, 41);
            this.B_REMOVE.TabIndex = 0;
            this.B_REMOVE.TabStop = false;
            this.B_REMOVE.Text = "Xóa";
            this.B_REMOVE.UseVisualStyleBackColor = true;
            // 
            // B_UPDATE
            // 
            this.B_UPDATE.Location = new System.Drawing.Point(111, 29);
            this.B_UPDATE.Name = "B_UPDATE";
            this.B_UPDATE.Size = new System.Drawing.Size(93, 41);
            this.B_UPDATE.TabIndex = 0;
            this.B_UPDATE.TabStop = false;
            this.B_UPDATE.Text = "Sửa";
            this.B_UPDATE.UseVisualStyleBackColor = true;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(12, 29);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(93, 41);
            this.B_ADD.TabIndex = 0;
            this.B_ADD.TabStop = false;
            this.B_ADD.Text = "Thêm";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(148, 142);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(166, 29);
            this.EMAIL.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 712);
            this.Controls.Add(this.P_MAIN);
            this.Controls.Add(this.P_INFORMATION);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StudentManager";
            this.Text = "StudentManager";
            this.P_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LIST)).EndInit();
            this.P_LIST_TOPMENU.ResumeLayout(false);
            this.P_LIST_TOPMENU.PerformLayout();
            this.P_LIST_CONTROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AVATAR)).EndInit();
            this.P_INFORMATION.ResumeLayout(false);
            this.P_INFORMATION.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton R_FEMALE;
        private System.Windows.Forms.RadioButton R_MALE;
        private System.Windows.Forms.Label L_AVATAR;
        private System.Windows.Forms.Label L_ADDRESS;
        private System.Windows.Forms.Panel P_MAIN;
        private System.Windows.Forms.DataGridView DGV_LIST;
        private System.Windows.Forms.Panel P_LIST_TOPMENU;
        private System.Windows.Forms.Button B_SEARCH;
        private System.Windows.Forms.TextBox T_SEARCH;
        private System.Windows.Forms.Panel P_LIST_CONTROL;
        private System.Windows.Forms.Button B_OK_IMPORT;
        private System.Windows.Forms.Button B_RELOAD;
        private System.Windows.Forms.Button B_IMPORT;
        private System.Windows.Forms.Button B_TOTAL;
        private System.Windows.Forms.Label L_GENDER;
        private System.Windows.Forms.Label L_PHONE;
        private System.Windows.Forms.Label L_BIRTHDAY;
        private System.Windows.Forms.Label L_LASTNAME;
        private System.Windows.Forms.Label L_FIRSTNAME;
        private System.Windows.Forms.Label L_MSSV;
        private System.Windows.Forms.PictureBox AVATAR;
        private System.Windows.Forms.RichTextBox ADDRESS;
        private System.Windows.Forms.DateTimePicker BIRTHDAY;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.TextBox LASTNAME;
        private System.Windows.Forms.TextBox FIRSTNAME;
        private System.Windows.Forms.TextBox MSSV;
        private System.Windows.Forms.Panel P_INFORMATION;
        private System.Windows.Forms.Button B_REMOVE;
        private System.Windows.Forms.Button B_UPDATE;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label label1;
    }
}