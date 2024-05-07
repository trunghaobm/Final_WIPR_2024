using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Student
{
    public partial class ChangePassword : Form
    {
        public string ServerName { get; set; } = "localhost";
        public string DatabaseName { get; set; } = "Final";
        public string TableName { get; set; } = "Student";
        public string UserID { get; set; }
        public string UserName { get; set; }
        public Database.Database DB { get; set; }
        public ChangePassword(string tableName, string userID, string userName)
        {
            InitializeComponent();
            TableName = tableName;
            UserID = userID;
            UserName = userName;
            L_TABLENAME.Text = tableName;
            L_ID.Text = userID + " " + userName;
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
        }


        private void B_OK_Click(object sender, EventArgs e)
        {
            if (NEWPASSWORD.Text == string.Empty)
            {
                return;
            }

            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE {0} ", TableName);
            query.AppendFormat("SET PASSWORD = CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512',N'{0}'), 2) ", NEWPASSWORD.Text);
            query.AppendFormat("WHERE MSSV = N'{0}'", UserID);

            using (SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                DB.Connect();

                cmd.ExecuteScalar();
                MessageBox.Show("Đổi mật khẩu thành công!");
                DB.Disconnect();
            }
        }

        private void B_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
