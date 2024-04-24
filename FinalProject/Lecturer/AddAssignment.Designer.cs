namespace FinalProject.Lecturer
{
    partial class AddAssignment
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
            this.P_DATA = new System.Windows.Forms.Panel();
            this.B_UPLOAD = new System.Windows.Forms.Button();
            this.FILENAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LECTUREID = new System.Windows.Forms.TextBox();
            this.B_ADD = new System.Windows.Forms.Button();
            this.COURESID = new System.Windows.Forms.TextBox();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_LABEL = new System.Windows.Forms.Label();
            this.P_DATA.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.B_UPLOAD);
            this.P_DATA.Controls.Add(this.FILENAME);
            this.P_DATA.Controls.Add(this.label1);
            this.P_DATA.Controls.Add(this.LECTUREID);
            this.P_DATA.Controls.Add(this.B_ADD);
            this.P_DATA.Controls.Add(this.COURESID);
            this.P_DATA.Controls.Add(this.L_ID);
            this.P_DATA.Controls.Add(this.L_LABEL);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 0);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(764, 333);
            this.P_DATA.TabIndex = 15;
            // 
            // B_UPLOAD
            // 
            this.B_UPLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_UPLOAD.Location = new System.Drawing.Point(657, 143);
            this.B_UPLOAD.Name = "B_UPLOAD";
            this.B_UPLOAD.Size = new System.Drawing.Size(95, 29);
            this.B_UPLOAD.TabIndex = 15;
            this.B_UPLOAD.Text = "Upload";
            this.B_UPLOAD.UseVisualStyleBackColor = true;
            this.B_UPLOAD.Click += new System.EventHandler(this.B_UPLOAD_Click);
            // 
            // FILENAME
            // 
            this.FILENAME.Location = new System.Drawing.Point(240, 142);
            this.FILENAME.Name = "FILENAME";
            this.FILENAME.Size = new System.Drawing.Size(410, 29);
            this.FILENAME.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LECTUREID
            // 
            this.LECTUREID.Enabled = false;
            this.LECTUREID.Location = new System.Drawing.Point(240, 72);
            this.LECTUREID.Name = "LECTUREID";
            this.LECTUREID.Size = new System.Drawing.Size(410, 29);
            this.LECTUREID.TabIndex = 6;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(240, 177);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(410, 52);
            this.B_ADD.TabIndex = 12;
            this.B_ADD.Text = "ADD";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // COURESID
            // 
            this.COURESID.Enabled = false;
            this.COURESID.Location = new System.Drawing.Point(240, 107);
            this.COURESID.Name = "COURESID";
            this.COURESID.Size = new System.Drawing.Size(410, 29);
            this.COURESID.TabIndex = 0;
            // 
            // L_ID
            // 
            this.L_ID.Location = new System.Drawing.Point(38, 73);
            this.L_ID.Name = "L_ID";
            this.L_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_ID.Size = new System.Drawing.Size(196, 29);
            this.L_ID.TabIndex = 10;
            this.L_ID.Text = "Mã giảng viên";
            this.L_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_LABEL
            // 
            this.L_LABEL.Location = new System.Drawing.Point(38, 108);
            this.L_LABEL.Name = "L_LABEL";
            this.L_LABEL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_LABEL.Size = new System.Drawing.Size(196, 29);
            this.L_LABEL.TabIndex = 9;
            this.L_LABEL.Text = "Mã khóa học";
            this.L_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 333);
            this.Controls.Add(this.P_DATA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddAssignment";
            this.Text = "AddAssignment";
            this.P_DATA.ResumeLayout(false);
            this.P_DATA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.TextBox FILENAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LECTUREID;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.TextBox COURESID;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_LABEL;
        private System.Windows.Forms.Button B_UPLOAD;
    }
}