namespace FinalProject.Student
{
    partial class CourseRegistion
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
            this.DGV_DATA = new System.Windows.Forms.DataGridView();
            this.P_DATA = new System.Windows.Forms.Panel();
            this.P_BOTCONTROLS = new System.Windows.Forms.Panel();
            this.B_ADD = new System.Windows.Forms.Button();
            this.B_CANCEL = new System.Windows.Forms.Button();
            this.P_TOPCONTROLS = new System.Windows.Forms.Panel();
            this.SEARCH = new System.Windows.Forms.TextBox();
            this.B_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
            this.P_DATA.SuspendLayout();
            this.P_BOTCONTROLS.SuspendLayout();
            this.P_TOPCONTROLS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DATA
            // 
            this.DGV_DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DATA.Location = new System.Drawing.Point(0, 0);
            this.DGV_DATA.Name = "DGV_DATA";
            this.DGV_DATA.Size = new System.Drawing.Size(910, 447);
            this.DGV_DATA.TabIndex = 0;
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.DGV_DATA);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 70);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(910, 447);
            this.P_DATA.TabIndex = 5;
            // 
            // P_BOTCONTROLS
            // 
            this.P_BOTCONTROLS.Controls.Add(this.B_ADD);
            this.P_BOTCONTROLS.Controls.Add(this.B_CANCEL);
            this.P_BOTCONTROLS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_BOTCONTROLS.Location = new System.Drawing.Point(0, 517);
            this.P_BOTCONTROLS.Name = "P_BOTCONTROLS";
            this.P_BOTCONTROLS.Size = new System.Drawing.Size(910, 87);
            this.P_BOTCONTROLS.TabIndex = 4;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(817, 23);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(81, 41);
            this.B_ADD.TabIndex = 0;
            this.B_ADD.Text = "Add";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // B_CANCEL
            // 
            this.B_CANCEL.BackColor = System.Drawing.Color.Red;
            this.B_CANCEL.Location = new System.Drawing.Point(12, 23);
            this.B_CANCEL.Name = "B_CANCEL";
            this.B_CANCEL.Size = new System.Drawing.Size(81, 41);
            this.B_CANCEL.TabIndex = 0;
            this.B_CANCEL.Text = "Cancel";
            this.B_CANCEL.UseVisualStyleBackColor = false;
            // 
            // P_TOPCONTROLS
            // 
            this.P_TOPCONTROLS.Controls.Add(this.SEARCH);
            this.P_TOPCONTROLS.Controls.Add(this.B_SEARCH);
            this.P_TOPCONTROLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_TOPCONTROLS.Location = new System.Drawing.Point(0, 0);
            this.P_TOPCONTROLS.Name = "P_TOPCONTROLS";
            this.P_TOPCONTROLS.Size = new System.Drawing.Size(910, 70);
            this.P_TOPCONTROLS.TabIndex = 3;
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(50, 17);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(186, 29);
            this.SEARCH.TabIndex = 2;
            // 
            // B_SEARCH
            // 
            this.B_SEARCH.Location = new System.Drawing.Point(242, 17);
            this.B_SEARCH.Name = "B_SEARCH";
            this.B_SEARCH.Size = new System.Drawing.Size(107, 29);
            this.B_SEARCH.TabIndex = 1;
            this.B_SEARCH.Text = "Search";
            this.B_SEARCH.UseVisualStyleBackColor = true;
            // 
            // CourseRegistion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 604);
            this.Controls.Add(this.P_DATA);
            this.Controls.Add(this.P_BOTCONTROLS);
            this.Controls.Add(this.P_TOPCONTROLS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CourseRegistion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoureRegistion";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.P_DATA.ResumeLayout(false);
            this.P_BOTCONTROLS.ResumeLayout(false);
            this.P_TOPCONTROLS.ResumeLayout(false);
            this.P_TOPCONTROLS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.Panel P_BOTCONTROLS;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Button B_CANCEL;
        private System.Windows.Forms.Panel P_TOPCONTROLS;
        private System.Windows.Forms.TextBox SEARCH;
        private System.Windows.Forms.Button B_SEARCH;
    }
}