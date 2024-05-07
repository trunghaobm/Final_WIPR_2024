namespace FinalProject.Student
{
    partial class Assignment
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
            this.P_SEARCH = new System.Windows.Forms.Panel();
            this.B_SEARCH = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.TextBox();
            this.DGV_DATA = new System.Windows.Forms.DataGridView();
            this.P_DATA = new System.Windows.Forms.Panel();
            this.P_CONTROL = new System.Windows.Forms.Panel();
            this.B_RELOAD = new System.Windows.Forms.Button();
            this.B_SUBMIT_ASSIGNMENT = new System.Windows.Forms.Button();
            this.B_DOWNLOAD_DOC = new System.Windows.Forms.Button();
            this.P_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
            this.P_DATA.SuspendLayout();
            this.P_CONTROL.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_SEARCH
            // 
            this.P_SEARCH.Controls.Add(this.B_SEARCH);
            this.P_SEARCH.Controls.Add(this.SEARCH);
            this.P_SEARCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_SEARCH.Location = new System.Drawing.Point(0, 0);
            this.P_SEARCH.Margin = new System.Windows.Forms.Padding(6);
            this.P_SEARCH.Name = "P_SEARCH";
            this.P_SEARCH.Size = new System.Drawing.Size(828, 91);
            this.P_SEARCH.TabIndex = 9;
            // 
            // B_SEARCH
            // 
            this.B_SEARCH.Location = new System.Drawing.Point(214, 33);
            this.B_SEARCH.Name = "B_SEARCH";
            this.B_SEARCH.Size = new System.Drawing.Size(75, 29);
            this.B_SEARCH.TabIndex = 1;
            this.B_SEARCH.TabStop = false;
            this.B_SEARCH.Text = "Seach";
            this.B_SEARCH.UseVisualStyleBackColor = true;
            this.B_SEARCH.Click += new System.EventHandler(this.B_SEARCH_Click);
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(12, 33);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(196, 29);
            this.SEARCH.TabIndex = 0;
            this.SEARCH.TabStop = false;
            // 
            // DGV_DATA
            // 
            this.DGV_DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DATA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DATA.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_DATA.Location = new System.Drawing.Point(0, 0);
            this.DGV_DATA.Name = "DGV_DATA";
            this.DGV_DATA.Size = new System.Drawing.Size(828, 388);
            this.DGV_DATA.TabIndex = 0;
            this.DGV_DATA.TabStop = false;
            // 
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.DGV_DATA);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 91);
            this.P_DATA.Margin = new System.Windows.Forms.Padding(6);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(828, 388);
            this.P_DATA.TabIndex = 10;
            // 
            // P_CONTROL
            // 
            this.P_CONTROL.Controls.Add(this.B_DOWNLOAD_DOC);
            this.P_CONTROL.Controls.Add(this.B_RELOAD);
            this.P_CONTROL.Controls.Add(this.B_SUBMIT_ASSIGNMENT);
            this.P_CONTROL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_CONTROL.Location = new System.Drawing.Point(0, 479);
            this.P_CONTROL.Margin = new System.Windows.Forms.Padding(6);
            this.P_CONTROL.Name = "P_CONTROL";
            this.P_CONTROL.Size = new System.Drawing.Size(828, 66);
            this.P_CONTROL.TabIndex = 11;
            // 
            // B_RELOAD
            // 
            this.B_RELOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_RELOAD.Location = new System.Drawing.Point(683, 9);
            this.B_RELOAD.Name = "B_RELOAD";
            this.B_RELOAD.Size = new System.Drawing.Size(133, 39);
            this.B_RELOAD.TabIndex = 0;
            this.B_RELOAD.TabStop = false;
            this.B_RELOAD.Text = "Tải lại";
            this.B_RELOAD.UseVisualStyleBackColor = true;
            this.B_RELOAD.Click += new System.EventHandler(this.B_RELOAD_Click);
            // 
            // B_SUBMIT_ASSIGNMENT
            // 
            this.B_SUBMIT_ASSIGNMENT.Location = new System.Drawing.Point(12, 9);
            this.B_SUBMIT_ASSIGNMENT.Name = "B_SUBMIT_ASSIGNMENT";
            this.B_SUBMIT_ASSIGNMENT.Size = new System.Drawing.Size(133, 39);
            this.B_SUBMIT_ASSIGNMENT.TabIndex = 0;
            this.B_SUBMIT_ASSIGNMENT.TabStop = false;
            this.B_SUBMIT_ASSIGNMENT.Text = "Thêm";
            this.B_SUBMIT_ASSIGNMENT.UseVisualStyleBackColor = true;
            this.B_SUBMIT_ASSIGNMENT.Click += new System.EventHandler(this.B_SUBMIT_ASSIGNMENT_Click);
            // 
            // B_DOWNLOAD_DOC
            // 
            this.B_DOWNLOAD_DOC.Location = new System.Drawing.Point(151, 9);
            this.B_DOWNLOAD_DOC.Name = "B_DOWNLOAD_DOC";
            this.B_DOWNLOAD_DOC.Size = new System.Drawing.Size(133, 39);
            this.B_DOWNLOAD_DOC.TabIndex = 0;
            this.B_DOWNLOAD_DOC.TabStop = false;
            this.B_DOWNLOAD_DOC.Text = "Tải tài liệu";
            this.B_DOWNLOAD_DOC.UseVisualStyleBackColor = true;
            this.B_DOWNLOAD_DOC.Click += new System.EventHandler(this.B_DOWNLOAD_DOC_Click);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 545);
            this.Controls.Add(this.P_DATA);
            this.Controls.Add(this.P_SEARCH);
            this.Controls.Add(this.P_CONTROL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Assignment";
            this.Text = "Assigment";
            this.P_SEARCH.ResumeLayout(false);
            this.P_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.P_DATA.ResumeLayout(false);
            this.P_CONTROL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_SEARCH;
        private System.Windows.Forms.Button B_SEARCH;
        private System.Windows.Forms.TextBox SEARCH;
        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.Panel P_CONTROL;
        private System.Windows.Forms.Button B_RELOAD;
        private System.Windows.Forms.Button B_SUBMIT_ASSIGNMENT;
        private System.Windows.Forms.Button B_DOWNLOAD_DOC;
    }
}