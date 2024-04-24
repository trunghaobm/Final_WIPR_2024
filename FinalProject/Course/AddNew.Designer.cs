namespace FinalProject.Course
{
    partial class AddNew
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
            this.ID = new System.Windows.Forms.TextBox();
            this.B_ADD = new System.Windows.Forms.Button();
            this.LABEL = new System.Windows.Forms.TextBox();
            this.DESCRIPTION = new System.Windows.Forms.RichTextBox();
            this.PERIOD = new System.Windows.Forms.TextBox();
            this.L_DESCRIPTION = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_PERIOD = new System.Windows.Forms.Label();
            this.L_LABEL = new System.Windows.Forms.Label();
            this.SEMESTER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.P_DATA.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.SEMESTER);
            this.P_DATA.Controls.Add(this.label1);
            this.P_DATA.Controls.Add(this.ID);
            this.P_DATA.Controls.Add(this.B_ADD);
            this.P_DATA.Controls.Add(this.LABEL);
            this.P_DATA.Controls.Add(this.DESCRIPTION);
            this.P_DATA.Controls.Add(this.PERIOD);
            this.P_DATA.Controls.Add(this.L_DESCRIPTION);
            this.P_DATA.Controls.Add(this.L_ID);
            this.P_DATA.Controls.Add(this.L_PERIOD);
            this.P_DATA.Controls.Add(this.L_LABEL);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 0);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(771, 551);
            this.P_DATA.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(240, 72);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(410, 29);
            this.ID.TabIndex = 6;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(240, 338);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(410, 52);
            this.B_ADD.TabIndex = 12;
            this.B_ADD.Text = "ADD";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // LABEL
            // 
            this.LABEL.Location = new System.Drawing.Point(240, 107);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(410, 29);
            this.LABEL.TabIndex = 0;
            this.LABEL.TextChanged += new System.EventHandler(this.LABEL_TextChanged);
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Location = new System.Drawing.Point(240, 213);
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Size = new System.Drawing.Size(410, 118);
            this.DESCRIPTION.TabIndex = 2;
            this.DESCRIPTION.Text = "";
            // 
            // PERIOD
            // 
            this.PERIOD.Location = new System.Drawing.Point(240, 177);
            this.PERIOD.Name = "PERIOD";
            this.PERIOD.Size = new System.Drawing.Size(410, 29);
            this.PERIOD.TabIndex = 1;
            // 
            // L_DESCRIPTION
            // 
            this.L_DESCRIPTION.Location = new System.Drawing.Point(38, 213);
            this.L_DESCRIPTION.Name = "L_DESCRIPTION";
            this.L_DESCRIPTION.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_DESCRIPTION.Size = new System.Drawing.Size(196, 29);
            this.L_DESCRIPTION.TabIndex = 7;
            this.L_DESCRIPTION.Text = "Description";
            this.L_DESCRIPTION.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ID
            // 
            this.L_ID.Location = new System.Drawing.Point(38, 73);
            this.L_ID.Name = "L_ID";
            this.L_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_ID.Size = new System.Drawing.Size(196, 29);
            this.L_ID.TabIndex = 10;
            this.L_ID.Text = "Course ID";
            this.L_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_PERIOD
            // 
            this.L_PERIOD.Location = new System.Drawing.Point(38, 178);
            this.L_PERIOD.Name = "L_PERIOD";
            this.L_PERIOD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_PERIOD.Size = new System.Drawing.Size(196, 29);
            this.L_PERIOD.TabIndex = 8;
            this.L_PERIOD.Text = "Period";
            this.L_PERIOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_LABEL
            // 
            this.L_LABEL.Location = new System.Drawing.Point(38, 108);
            this.L_LABEL.Name = "L_LABEL";
            this.L_LABEL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_LABEL.Size = new System.Drawing.Size(196, 29);
            this.L_LABEL.TabIndex = 9;
            this.L_LABEL.Text = "Label";
            this.L_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SEMESTER
            // 
            this.SEMESTER.Location = new System.Drawing.Point(240, 142);
            this.SEMESTER.Name = "SEMESTER";
            this.SEMESTER.Size = new System.Drawing.Size(410, 29);
            this.SEMESTER.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Semester";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 551);
            this.Controls.Add(this.P_DATA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.P_DATA.ResumeLayout(false);
            this.P_DATA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.TextBox LABEL;
        private System.Windows.Forms.RichTextBox DESCRIPTION;
        private System.Windows.Forms.TextBox PERIOD;
        private System.Windows.Forms.Label L_DESCRIPTION;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_PERIOD;
        private System.Windows.Forms.Label L_LABEL;
        private System.Windows.Forms.TextBox SEMESTER;
        private System.Windows.Forms.Label label1;
    }
}