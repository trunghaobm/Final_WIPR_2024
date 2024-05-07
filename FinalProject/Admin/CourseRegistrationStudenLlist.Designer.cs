namespace FinalProject.Admin
{
    partial class CourseRegistrationStudenLlist
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
            this.P_TOPPANEL = new System.Windows.Forms.Panel();
            this.SEARCH = new System.Windows.Forms.TextBox();
            this.B_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
            this.P_TOPPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DATA
            // 
            this.DGV_DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DATA.Location = new System.Drawing.Point(0, 57);
            this.DGV_DATA.Name = "DGV_DATA";
            this.DGV_DATA.Size = new System.Drawing.Size(866, 464);
            this.DGV_DATA.TabIndex = 0;
            this.DGV_DATA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DATA_CellDoubleClick);
            // 
            // P_TOPPANEL
            // 
            this.P_TOPPANEL.Controls.Add(this.B_SEARCH);
            this.P_TOPPANEL.Controls.Add(this.SEARCH);
            this.P_TOPPANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_TOPPANEL.Location = new System.Drawing.Point(0, 0);
            this.P_TOPPANEL.Name = "P_TOPPANEL";
            this.P_TOPPANEL.Size = new System.Drawing.Size(866, 57);
            this.P_TOPPANEL.TabIndex = 1;
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(22, 12);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(294, 29);
            this.SEARCH.TabIndex = 0;
            this.SEARCH.TextChanged += new System.EventHandler(this.SEARCH_TextChanged);
            // 
            // B_SEARCH
            // 
            this.B_SEARCH.Location = new System.Drawing.Point(323, 12);
            this.B_SEARCH.Name = "B_SEARCH";
            this.B_SEARCH.Size = new System.Drawing.Size(100, 29);
            this.B_SEARCH.TabIndex = 1;
            this.B_SEARCH.Text = "Search";
            this.B_SEARCH.UseVisualStyleBackColor = true;
            // 
            // CourseRegistrationStudenLlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.Controls.Add(this.DGV_DATA);
            this.Controls.Add(this.P_TOPPANEL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CourseRegistrationStudenLlist";
            this.Text = "CourseRegistrationStudenLlist";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.P_TOPPANEL.ResumeLayout(false);
            this.P_TOPPANEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.Panel P_TOPPANEL;
        private System.Windows.Forms.Button B_SEARCH;
        private System.Windows.Forms.TextBox SEARCH;
    }
}