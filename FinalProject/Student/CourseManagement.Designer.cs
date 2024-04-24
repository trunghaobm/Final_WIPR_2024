namespace FinalProject.Student
{
    partial class CourseManagement
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
            this.P_TOPCONTROL = new System.Windows.Forms.Panel();
            this.SEARCH = new System.Windows.Forms.TextBox();
            this.B_SEARCH = new System.Windows.Forms.Button();
            this.B_RELOAD = new System.Windows.Forms.Button();
            this.P_CONTROL = new System.Windows.Forms.Panel();
            this.B_REMOVE = new System.Windows.Forms.Button();
            this.B_ADD = new System.Windows.Forms.Button();
            this.P_DATA = new System.Windows.Forms.Panel();
            this.DGV_DATA = new System.Windows.Forms.DataGridView();
            this.P_TOPCONTROL.SuspendLayout();
            this.P_CONTROL.SuspendLayout();
            this.P_DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // P_TOPCONTROL
            // 
            this.P_TOPCONTROL.Controls.Add(this.SEARCH);
            this.P_TOPCONTROL.Controls.Add(this.B_SEARCH);
            this.P_TOPCONTROL.Controls.Add(this.B_RELOAD);
            this.P_TOPCONTROL.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_TOPCONTROL.Location = new System.Drawing.Point(0, 0);
            this.P_TOPCONTROL.Name = "P_TOPCONTROL";
            this.P_TOPCONTROL.Size = new System.Drawing.Size(699, 70);
            this.P_TOPCONTROL.TabIndex = 0;
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
            this.B_SEARCH.Click += new System.EventHandler(this.B_SEARCH_Click);
            // 
            // B_RELOAD
            // 
            this.B_RELOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_RELOAD.Location = new System.Drawing.Point(647, 12);
            this.B_RELOAD.Name = "B_RELOAD";
            this.B_RELOAD.Size = new System.Drawing.Size(40, 40);
            this.B_RELOAD.TabIndex = 0;
            this.B_RELOAD.UseVisualStyleBackColor = true;
            this.B_RELOAD.Click += new System.EventHandler(this.B_RELOAD_Click);
            // 
            // P_CONTROL
            // 
            this.P_CONTROL.Controls.Add(this.B_REMOVE);
            this.P_CONTROL.Controls.Add(this.B_ADD);
            this.P_CONTROL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_CONTROL.Location = new System.Drawing.Point(0, 479);
            this.P_CONTROL.Name = "P_CONTROL";
            this.P_CONTROL.Size = new System.Drawing.Size(699, 87);
            this.P_CONTROL.TabIndex = 1;
            // 
            // B_REMOVE
            // 
            this.B_REMOVE.Location = new System.Drawing.Point(99, 23);
            this.B_REMOVE.Name = "B_REMOVE";
            this.B_REMOVE.Size = new System.Drawing.Size(81, 41);
            this.B_REMOVE.TabIndex = 0;
            this.B_REMOVE.Text = "Xóa";
            this.B_REMOVE.UseVisualStyleBackColor = true;
            this.B_REMOVE.Click += new System.EventHandler(this.B_REMOVE_Click);
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(12, 23);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(81, 41);
            this.B_ADD.TabIndex = 0;
            this.B_ADD.Text = "Thêm";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.DGV_DATA);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 70);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(699, 409);
            this.P_DATA.TabIndex = 2;
            // 
            // DGV_DATA
            // 
            this.DGV_DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DATA.Location = new System.Drawing.Point(0, 0);
            this.DGV_DATA.Name = "DGV_DATA";
            this.DGV_DATA.Size = new System.Drawing.Size(699, 409);
            this.DGV_DATA.TabIndex = 0;
            // 
            // CourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 566);
            this.Controls.Add(this.P_DATA);
            this.Controls.Add(this.P_CONTROL);
            this.Controls.Add(this.P_TOPCONTROL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CourseManagement";
            this.Text = "CourseManagement";
            this.P_TOPCONTROL.ResumeLayout(false);
            this.P_TOPCONTROL.PerformLayout();
            this.P_CONTROL.ResumeLayout(false);
            this.P_DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_TOPCONTROL;
        private System.Windows.Forms.Button B_RELOAD;
        private System.Windows.Forms.Panel P_CONTROL;
        private System.Windows.Forms.Button B_REMOVE;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.TextBox SEARCH;
        private System.Windows.Forms.Button B_SEARCH;
    }
}