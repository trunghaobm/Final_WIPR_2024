namespace FinalProject.Admin
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
            this.L_TABLENAME = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_NEWPASSWORD = new System.Windows.Forms.Label();
            this.NEWPASSWORD = new System.Windows.Forms.TextBox();
            this.B_OK = new System.Windows.Forms.Button();
            this.B_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_TABLENAME
            // 
            this.L_TABLENAME.AutoSize = true;
            this.L_TABLENAME.Location = new System.Drawing.Point(65, 13);
            this.L_TABLENAME.Name = "L_TABLENAME";
            this.L_TABLENAME.Size = new System.Drawing.Size(106, 24);
            this.L_TABLENAME.TabIndex = 0;
            this.L_TABLENAME.Text = "Tablename";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(65, 37);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(27, 24);
            this.L_ID.TabIndex = 0;
            this.L_ID.Text = "ID";
            // 
            // L_NEWPASSWORD
            // 
            this.L_NEWPASSWORD.Location = new System.Drawing.Point(12, 85);
            this.L_NEWPASSWORD.Name = "L_NEWPASSWORD";
            this.L_NEWPASSWORD.Size = new System.Drawing.Size(159, 24);
            this.L_NEWPASSWORD.TabIndex = 0;
            this.L_NEWPASSWORD.Text = "Mật khẩu mới";
            this.L_NEWPASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NEWPASSWORD
            // 
            this.NEWPASSWORD.Location = new System.Drawing.Point(177, 80);
            this.NEWPASSWORD.Name = "NEWPASSWORD";
            this.NEWPASSWORD.Size = new System.Drawing.Size(294, 29);
            this.NEWPASSWORD.TabIndex = 1;
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(365, 116);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(105, 33);
            this.B_OK.TabIndex = 2;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_CANCEL
            // 
            this.B_CANCEL.Location = new System.Drawing.Point(366, 155);
            this.B_CANCEL.Name = "B_CANCEL";
            this.B_CANCEL.Size = new System.Drawing.Size(105, 33);
            this.B_CANCEL.TabIndex = 3;
            this.B_CANCEL.Text = "Cancel";
            this.B_CANCEL.UseVisualStyleBackColor = true;
            this.B_CANCEL.Click += new System.EventHandler(this.B_CANCEL_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 229);
            this.Controls.Add(this.B_CANCEL);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.NEWPASSWORD);
            this.Controls.Add(this.L_NEWPASSWORD);
            this.Controls.Add(this.L_ID);
            this.Controls.Add(this.L_TABLENAME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_TABLENAME;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_NEWPASSWORD;
        private System.Windows.Forms.TextBox NEWPASSWORD;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Button B_CANCEL;
    }
}