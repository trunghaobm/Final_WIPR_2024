using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Lecturer
{
    public partial class ChangePassword : Form
    {
        public string ServerName { get; set; } = "localhost";
        public string DatabaseName { get; set; } = "Final";
        public string TableName { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public Database.Database DB { get; set; }
        public ChangePassword( string userID, string userName)
        {
            InitializeComponent();
            TableName = "LECTURER";
            UserID = userID;
            UserName = userName;
            L_ID.Text = userID + " " + userName;
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
        }

        public bool CheckDataRequire()
        {
            string msg = string.Empty;
            bool pass = true;

            if (string.IsNullOrEmpty(CURRENTPASSWORD.Text.Trim()))
            {
                msg += "Chưa nhập mật khẩu hiện tại\n";
                pass = false;
            }
            if (string.IsNullOrEmpty(NEWPASSWORD.Text.Trim()))
            {
                msg += "Chưa nhập mật khẩu mới\n";
                pass = false;
            }
            if (string.IsNullOrEmpty(CONFIRMNEWPASSWORD.Text.Trim()))
            {
                msg += "Chưa nhập lại mật khẩu mới\n";
                pass = false;
            }

            if(!pass) MessageBox.Show(msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return pass;
        }

        public bool CheckDataRefer()
        {
            string msg = string.Empty;
            bool pass = true;

            if (!Email.IsValidPassword(NEWPASSWORD.Text))
            {
                msg += "Mật khẩu không đúng định dạng(a-z,A-Z,0-9 và một số ký tự đặc biệt)\n";
                pass = false;
            }
            if (NEWPASSWORD.Text != CONFIRMNEWPASSWORD.Text) 
            {
                msg += "Mật khẩu không trùng khớp\n";
                pass = false;
            }
            if (!CheckMatchPassword(CURRENTPASSWORD.Text, UserID))
            {
                msg += "Mật khẩu không đúng\n";
                pass = false;
            }
            if (!pass) MessageBox.Show(msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return pass;
        }
        
        public bool CheckMatchPassword(string password, string lectureID)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT PASSWORD FROM {0} WHERE " +
                                                    "ID = N'{1}' AND " +
                                                    "PASSWORD = CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512',N'{2}'), 2) ", TableName, lectureID, password);
            DataTable result = new DataTable();
            using(SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), DB.Connection))
            {
                DB.Connect();

                adapter.Fill(result);

                DB.Disconnect();
            }

            if (result.Rows.Count == 1)
                return true;
            return false;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            if (!CheckDataRequire())
            {
                return;
            }
            if (!CheckDataRefer())
            {
                return;
            }

            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE {0} ", TableName);
            query.AppendFormat("SET PASSWORD = CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512',N'{0}'), 2) ", NEWPASSWORD.Text);
            query.AppendFormat("WHERE ID = N'{0}'", UserID);

            using (SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                try
                {
                    DB.Connect();

                    cmd.ExecuteScalar();
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    DB.Disconnect();
                    string filePath = "SaveLog.txt";
                    File.Delete(filePath);
                    this.Close();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void B_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
