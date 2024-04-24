using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Course
{
    public partial class AddNew : Form
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database Database { get; set; }
        public AddNew()
        {
            InitializeComponent();
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "COURSE";
            Database = new Database.Database(ServerName, DatabaseName, TableName);
        }

        private void LABEL_TextChanged(object sender, EventArgs e)
        {
            if (LABEL.Text.Length == 0)
            {
                ID.Text = string.Empty;
            }
            else
            {
                DateTime now = DateTime.Now;
                ID.Text = LABEL.Text + now.ToString("yyyyMMddhhmmss");
            }
        }

        public bool CheckDataRefer()
        {
            return true;
        }

        public bool CheckDataRequire()
        {
            bool check = true;
            if (LABEL.Text == string.Empty)
            {
                ToolTip tip = new ToolTip();
                tip.Show("Khong duoc de trong", LABEL);
                check = false;
            }
            if (PERIOD.Text == string.Empty)
            {
                ToolTip tip = new ToolTip();
                tip.Show("Khong duoc de trong", PERIOD);
                check = false;
            }
            if (DESCRIPTION.Text == string.Empty)
            {
                ToolTip tip = new ToolTip();
                tip.Show("Khong duoc de trong", DESCRIPTION);
                check = false;
            }
            return check;
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            if (!CheckDataRefer()) return;
            if (!CheckDataRequire()) return;

            DataTable source = GetDataToTable();

            if (Database.InsertRow(source))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm mới");
            }
        }

        public DataTable GetDataToTable()
        {
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            foreach (Control control in P_DATA.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    dt.Columns.Add(control.Name);
                    dt.Rows[0][control.Name] = control.Text;
                }
            }
            return dt;
        }
    }
}
