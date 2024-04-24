namespace FinalProject.Course
{
    partial class Main
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
            this.P_DATA = new System.Windows.Forms.Panel();
            this.DGV_DATA = new System.Windows.Forms.DataGridView();
            this.P_CONTROL = new System.Windows.Forms.Panel();
            this.B_UPDATE = new System.Windows.Forms.Button();
            this.B_REMOVE = new System.Windows.Forms.Button();
            this.B_ADD = new System.Windows.Forms.Button();
            this.P_SEARCH.SuspendLayout();
            this.P_DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).BeginInit();
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
            this.P_SEARCH.Size = new System.Drawing.Size(967, 91);
            this.P_SEARCH.TabIndex = 3;
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
            // P_DATA
            // 
            this.P_DATA.Controls.Add(this.DGV_DATA);
            this.P_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DATA.Location = new System.Drawing.Point(0, 91);
            this.P_DATA.Margin = new System.Windows.Forms.Padding(6);
            this.P_DATA.Name = "P_DATA";
            this.P_DATA.Size = new System.Drawing.Size(967, 442);
            this.P_DATA.TabIndex = 4;
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
            this.DGV_DATA.Size = new System.Drawing.Size(967, 442);
            this.DGV_DATA.TabIndex = 0;
            this.DGV_DATA.TabStop = false;
            this.DGV_DATA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DATA_CellDoubleClick);
            // 
            // P_CONTROL
            // 
            this.P_CONTROL.Controls.Add(this.B_UPDATE);
            this.P_CONTROL.Controls.Add(this.B_REMOVE);
            this.P_CONTROL.Controls.Add(this.B_ADD);
            this.P_CONTROL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_CONTROL.Location = new System.Drawing.Point(0, 533);
            this.P_CONTROL.Margin = new System.Windows.Forms.Padding(6);
            this.P_CONTROL.Name = "P_CONTROL";
            this.P_CONTROL.Size = new System.Drawing.Size(967, 66);
            this.P_CONTROL.TabIndex = 5;
            // 
            // B_UPDATE
            // 
            this.B_UPDATE.Location = new System.Drawing.Point(151, 9);
            this.B_UPDATE.Name = "B_UPDATE";
            this.B_UPDATE.Size = new System.Drawing.Size(133, 39);
            this.B_UPDATE.TabIndex = 0;
            this.B_UPDATE.TabStop = false;
            this.B_UPDATE.Text = "Sửa";
            this.B_UPDATE.UseVisualStyleBackColor = true;
            this.B_UPDATE.Click += new System.EventHandler(this.B_UPDATE_Click);
            // 
            // B_REMOVE
            // 
            this.B_REMOVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_REMOVE.Location = new System.Drawing.Point(822, 9);
            this.B_REMOVE.Name = "B_REMOVE";
            this.B_REMOVE.Size = new System.Drawing.Size(133, 39);
            this.B_REMOVE.TabIndex = 0;
            this.B_REMOVE.TabStop = false;
            this.B_REMOVE.Text = "Xóa";
            this.B_REMOVE.UseVisualStyleBackColor = true;
            this.B_REMOVE.Click += new System.EventHandler(this.B_REMOVE_Click);
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(12, 9);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(133, 39);
            this.B_ADD.TabIndex = 0;
            this.B_ADD.TabStop = false;
            this.B_ADD.Text = "Thêm";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 599);
            this.Controls.Add(this.P_DATA);
            this.Controls.Add(this.P_CONTROL);
            this.Controls.Add(this.P_SEARCH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Main";
            this.P_SEARCH.ResumeLayout(false);
            this.P_SEARCH.PerformLayout();
            this.P_DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATA)).EndInit();
            this.P_CONTROL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_SEARCH;
        private System.Windows.Forms.Button B_SEARCH;
        private System.Windows.Forms.TextBox SEARCH;
        private System.Windows.Forms.Panel P_DATA;
        private System.Windows.Forms.DataGridView DGV_DATA;
        private System.Windows.Forms.Panel P_CONTROL;
        private System.Windows.Forms.Button B_UPDATE;
        private System.Windows.Forms.Button B_REMOVE;
        private System.Windows.Forms.Button B_ADD;
    }
}