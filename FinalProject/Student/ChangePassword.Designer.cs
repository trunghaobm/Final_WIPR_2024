namespace FinalProject.Student
{
    partial class ChangePassword
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
            this.B_CANCEL = new System.Windows.Forms.Button();
            this.B_OK = new System.Windows.Forms.Button();
            this.NEWPASSWORD = new System.Windows.Forms.TextBox();
            this.L_NEWPASSWORD = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_TABLENAME = new System.Windows.Forms.Label();
            this.L_CURRENTPASSWORD = new System.Windows.Forms.Label();
            this.CURRENTPASSWORD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CONFIRMNEWPASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_CANCEL
            // 
            this.B_CANCEL.Location = new System.Drawing.Point(395, 208);
            this.B_CANCEL.Name = "B_CANCEL";
            this.B_CANCEL.Size = new System.Drawing.Size(105, 33);
            this.B_CANCEL.TabIndex = 4;
            this.B_CANCEL.Text = "Cancel";
            this.B_CANCEL.UseVisualStyleBackColor = true;
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(394, 169);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(105, 33);
            this.B_OK.TabIndex = 3;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            // 
            // NEWPASSWORD
            // 
            this.NEWPASSWORD.Location = new System.Drawing.Point(205, 99);
            this.NEWPASSWORD.Name = "NEWPASSWORD";
            this.NEWPASSWORD.Size = new System.Drawing.Size(294, 29);
            this.NEWPASSWORD.TabIndex = 1;
            // 
            // L_NEWPASSWORD
            // 
            this.L_NEWPASSWORD.Location = new System.Drawing.Point(12, 104);
            this.L_NEWPASSWORD.Name = "L_NEWPASSWORD";
            this.L_NEWPASSWORD.Size = new System.Drawing.Size(187, 24);
            this.L_NEWPASSWORD.TabIndex = 4;
            this.L_NEWPASSWORD.Text = "Mật khẩu mới";
            this.L_NEWPASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(12, 33);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(27, 24);
            this.L_ID.TabIndex = 5;
            this.L_ID.Text = "ID";
            // 
            // L_TABLENAME
            // 
            this.L_TABLENAME.AutoSize = true;
            this.L_TABLENAME.Location = new System.Drawing.Point(12, 9);
            this.L_TABLENAME.Name = "L_TABLENAME";
            this.L_TABLENAME.Size = new System.Drawing.Size(106, 24);
            this.L_TABLENAME.TabIndex = 6;
            this.L_TABLENAME.Text = "Tablename";
            // 
            // L_CURRENTPASSWORD
            // 
            this.L_CURRENTPASSWORD.Location = new System.Drawing.Point(12, 69);
            this.L_CURRENTPASSWORD.Name = "L_CURRENTPASSWORD";
            this.L_CURRENTPASSWORD.Size = new System.Drawing.Size(187, 24);
            this.L_CURRENTPASSWORD.TabIndex = 4;
            this.L_CURRENTPASSWORD.Text = "Mật khẩu ";
            this.L_CURRENTPASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CURRENTPASSWORD
            // 
            this.CURRENTPASSWORD.Location = new System.Drawing.Point(205, 64);
            this.CURRENTPASSWORD.Name = "CURRENTPASSWORD";
            this.CURRENTPASSWORD.Size = new System.Drawing.Size(294, 29);
            this.CURRENTPASSWORD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập lại mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CONFIRMNEWPASSWORD
            // 
            this.CONFIRMNEWPASSWORD.Location = new System.Drawing.Point(205, 134);
            this.CONFIRMNEWPASSWORD.Name = "CONFIRMNEWPASSWORD";
            this.CONFIRMNEWPASSWORD.Size = new System.Drawing.Size(294, 29);
            this.CONFIRMNEWPASSWORD.TabIndex = 2;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 281);
            this.Controls.Add(this.B_CANCEL);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.CURRENTPASSWORD);
            this.Controls.Add(this.L_CURRENTPASSWORD);
            this.Controls.Add(this.CONFIRMNEWPASSWORD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NEWPASSWORD);
            this.Controls.Add(this.L_NEWPASSWORD);
            this.Controls.Add(this.L_ID);
            this.Controls.Add(this.L_TABLENAME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_CANCEL;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.TextBox NEWPASSWORD;
        private System.Windows.Forms.Label L_NEWPASSWORD;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_TABLENAME;
        private System.Windows.Forms.Label L_CURRENTPASSWORD;
        private System.Windows.Forms.TextBox CURRENTPASSWORD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CONFIRMNEWPASSWORD;
    }
}