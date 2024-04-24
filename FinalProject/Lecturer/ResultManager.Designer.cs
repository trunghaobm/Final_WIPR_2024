namespace FinalProject.Course
{
    partial class ResultManager
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
            this.P_SEARCH_INFO = new System.Windows.Forms.Panel();
            this.B_OK = new System.Windows.Forms.Button();
            this.L_STDNAME = new System.Windows.Forms.Label();
            this.NAMEKEY = new System.Windows.Forms.TextBox();
            this.P_SEARCH_RESULT = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_EDIT_SCORE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
            this.P_SEARCH_INFO.SuspendLayout();
            this.P_SEARCH_RESULT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DATA
            // 
            this.DGV_DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DATA.Location = new System.Drawing.Point(0, 0);
            this.DGV_DATA.Name = "DGV_DATA";
            this.DGV_DATA.Size = new System.Drawing.Size(971, 542);
            this.DGV_DATA.TabIndex = 0;
            // 
            // P_SEARCH_INFO
            // 
            this.P_SEARCH_INFO.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.P_SEARCH_INFO.Controls.Add(this.B_OK);
            this.P_SEARCH_INFO.Controls.Add(this.L_STDNAME);
            this.P_SEARCH_INFO.Controls.Add(this.NAMEKEY);
            this.P_SEARCH_INFO.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_SEARCH_INFO.Location = new System.Drawing.Point(0, 0);
            this.P_SEARCH_INFO.Name = "P_SEARCH_INFO";
            this.P_SEARCH_INFO.Size = new System.Drawing.Size(971, 89);
            this.P_SEARCH_INFO.TabIndex = 2;
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(329, 14);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(81, 61);
            this.B_OK.TabIndex = 2;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            // 
            // L_STDNAME
            // 
            this.L_STDNAME.Location = new System.Drawing.Point(12, 14);
            this.L_STDNAME.Name = "L_STDNAME";
            this.L_STDNAME.Size = new System.Drawing.Size(311, 29);
            this.L_STDNAME.TabIndex = 1;
            this.L_STDNAME.Text = "Mã sinh viên hoặc mã khóa học";
            this.L_STDNAME.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // NAMEKEY
            // 
            this.NAMEKEY.Location = new System.Drawing.Point(12, 46);
            this.NAMEKEY.Name = "NAMEKEY";
            this.NAMEKEY.Size = new System.Drawing.Size(311, 29);
            this.NAMEKEY.TabIndex = 0;
            // 
            // P_SEARCH_RESULT
            // 
            this.P_SEARCH_RESULT.BackColor = System.Drawing.Color.Pink;
            this.P_SEARCH_RESULT.Controls.Add(this.DGV_DATA);
            this.P_SEARCH_RESULT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_SEARCH_RESULT.Location = new System.Drawing.Point(0, 0);
            this.P_SEARCH_RESULT.Name = "P_SEARCH_RESULT";
            this.P_SEARCH_RESULT.Size = new System.Drawing.Size(971, 542);
            this.P_SEARCH_RESULT.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_EDIT_SCORE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 67);
            this.panel1.TabIndex = 4;
            // 
            // B_EDIT_SCORE
            // 
            this.B_EDIT_SCORE.Location = new System.Drawing.Point(6, 6);
            this.B_EDIT_SCORE.Name = "B_EDIT_SCORE";
            this.B_EDIT_SCORE.Size = new System.Drawing.Size(104, 48);
            this.B_EDIT_SCORE.TabIndex = 0;
            this.B_EDIT_SCORE.Text = "Sửa điểm";
            this.B_EDIT_SCORE.UseVisualStyleBackColor = true;
            // 
            // ResultManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 609);
            this.Controls.Add(this.P_SEARCH_INFO);
            this.Controls.Add(this.P_SEARCH_RESULT);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResultManager";
            this.Text = "ResultManager";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.P_SEARCH_INFO.ResumeLayout(false);
            this.P_SEARCH_INFO.PerformLayout();
            this.P_SEARCH_RESULT.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.Panel P_SEARCH_INFO;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Label L_STDNAME;
        private System.Windows.Forms.TextBox NAMEKEY;
        private System.Windows.Forms.Panel P_SEARCH_RESULT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_EDIT_SCORE;
    }
}