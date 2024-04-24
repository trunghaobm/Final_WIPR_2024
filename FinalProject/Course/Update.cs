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
    public partial class Update : Form
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database Database { get; set; }
        public DataTable dataTable { get; set; }
        public Update()
        {
            InitializeComponent();
            FirstLoad();
        }
        public Update(DataTable source)
        {
            InitializeComponent();
            dataTable = source;
            FirstLoad();
            GetTableToData();
        }
        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "COURSE";
            Database = new Database.Database(ServerName, DatabaseName, TableName);
        }

        public void GetTableToData()
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                foreach (Control control in P_DATA.Controls)
                {
                    if (control.Name == column.ColumnName)
                    {
                        control.Text = dataTable.Rows[0][column.ColumnName].ToString();
                        continue;
                    }
                }
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

        private void B_UPDATE_Click(object sender, EventArgs e)
        {
            if (!CheckDataRefer()) return;
            if (!CheckDataRequire()) return;

            DataTable source = GetDataToTable();

            if (Database.UpdatetRow(source))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa");
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
