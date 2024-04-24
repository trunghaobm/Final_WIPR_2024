namespace FinalProject.Lecturer
{
    partial class ScoreUpdate
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
            this.L_NAME = new System.Windows.Forms.Label();
            this.L_COURSE = new System.Windows.Forms.Label();
            this.SCORE = new System.Windows.Forms.TextBox();
            this.B_CANCEL = new System.Windows.Forms.Button();
            this.B_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_NAME
            // 
            this.L_NAME.AutoSize = true;
            this.L_NAME.Location = new System.Drawing.Point(12, 9);
            this.L_NAME.Name = "L_NAME";
            this.L_NAME.Size = new System.Drawing.Size(61, 24);
            this.L_NAME.TabIndex = 0;
            this.L_NAME.Text = "Name";
            // 
            // L_COURSE
            // 
            this.L_COURSE.AutoSize = true;
            this.L_COURSE.Location = new System.Drawing.Point(12, 55);
            this.L_COURSE.Name = "L_COURSE";
            this.L_COURSE.Size = new System.Drawing.Size(65, 24);
            this.L_COURSE.TabIndex = 0;
            this.L_COURSE.Text = "Couse";
            // 
            // SCORE
            // 
            this.SCORE.Location = new System.Drawing.Point(13, 123);
            this.SCORE.Name = "SCORE";
            this.SCORE.Size = new System.Drawing.Size(235, 29);
            this.SCORE.TabIndex = 1;
            this.SCORE.TextChanged += new System.EventHandler(this.SCORE_TextChanged);
            this.SCORE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SCORE_KeyPress);
            // 
            // B_CANCEL
            // 
            this.B_CANCEL.Location = new System.Drawing.Point(16, 170);
            this.B_CANCEL.Name = "B_CANCEL";
            this.B_CANCEL.Size = new System.Drawing.Size(85, 36);
            this.B_CANCEL.TabIndex = 2;
            this.B_CANCEL.Text = "Cancel";
            this.B_CANCEL.UseVisualStyleBackColor = true;
            this.B_CANCEL.Click += new System.EventHandler(this.B_CANCEL_Click);
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(173, 170);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(75, 36);
            this.B_OK.TabIndex = 2;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // ScoreUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 239);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.B_CANCEL);
            this.Controls.Add(this.SCORE);
            this.Controls.Add(this.L_COURSE);
            this.Controls.Add(this.L_NAME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ScoreUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreUpdate";
            this.Shown += new System.EventHandler(this.ScoreUpdate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_NAME;
        private System.Windows.Forms.Label L_COURSE;
        private System.Windows.Forms.TextBox SCORE;
        private System.Windows.Forms.Button B_CANCEL;
        private System.Windows.Forms.Button B_OK;
    }
}