using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject.Login
{
    public partial class Login : Form
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database DB { get; set; }

        public Source.Role role;
        public bool isAutoLogin { get; set; } = true;
        public RegisterStudent registerStudent { get; set; }
        public RegisterLecturer registerLecturer { get; set; }
        public DataTable User {  get; set; }

        public Login()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "ADMIN";
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            registerStudent = new RegisterStudent();
            User = new DataTable();
            DB.Open();
            role = Role.Admin;
        }

        public bool CheckDataRefer()
        {
            if (!Source.Email.IsValidEmail(EMAIL.Text.Trim()))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Email không hợp lệ!", EMAIL);
                return false;
            }
            return true;
        }

        public bool CheckDataRequire()
        {
            if (EMAIL.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Email không được để trống!", EMAIL);
                return false;
            }
            if (PASSWORD.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Mật khẩu không được để trống!", PASSWORD);
                return false;
            }
            return true;
        }

        public bool TryLogin(string email, string password, bool remember)
        {
            DB.Open();
            using (SqlCommand command = new SqlCommand("TryLogin_" + TableName, DB.Connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EMAIL", email);
                command.Parameters.AddWithValue("@PASSWORD", password);


                DB.Connect();
                try
                {
                    int returnValue = (int)command.ExecuteScalar();

                    if (returnValue == 1)
                    {
                        if (CB_REMEMBER.Checked)
                        {
                            SaveLog(email, password, this.role);
                        }
                        User = DB.GetTable(email);
                        return true;
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            DB.Disconnect();
            return false;
        }

        public void SaveLog(string username, string password, Role role)
        {
            string filePath = "SaveLog.txt";
            if (CB_REMEMBER.Checked)
            {
                File.WriteAllText(filePath, role.ToString() + "\n" + username + "\n" + password);
            }
            else
            {
                File.Delete(filePath);
            }
        }

        public void RemoveAutoLogin()
        {
            string filePath = "SaveLog.txt";
            File.Delete(filePath);
        }

        public bool TryAutoLogin()
        {
            if (isAutoLogin)
            {
                string filePath = "SaveLog.txt";
                try
                {
                    string file = File.ReadAllText(filePath);
                    if (file == "") return false;
                    else
                    {
                        string[] user = file.Split('\n');
                        Enum.TryParse(user[0], out role);
                        ChangeRole();
                        this.DB.TableName = this.TableName;
                        if (!TryLogin(user[1], user[2], true))
                        {
                            RemoveAutoLogin();
                            return false;
                        }
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public void ChangeRole()
        {
            switch (role)
            {
                case Role.None: break;
                case Role.Admin:
                    TableName = "ADMIN";
                    break;
                case Role.Student:
                    TableName = "STUDENT";
                    break;
                case Role.Lecturer:
                    TableName = "LECTURER";
                    break;

                default: break;
            }
        }

        private void B_LOGIN_Click(object sender, EventArgs e)
        {
            if(!CheckDataRequire())
            {
                return ;
            }
            if(!CheckDataRefer())
            {
                return;
            }
            this.DB.TableName = this.TableName;

            if (TryLogin(EMAIL.Text, PASSWORD.Text, CB_REMEMBER.Checked))
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                this.Close();
            }
            else
            {
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            //if (TryAutoLogin())
            //{
            //    if (R_ADMIN.Checked) role = Role.Admin;
            //    this.Close();
            //}
        }

        private void B_CANCLE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_FORGOTPASS_Click(object sender, EventArgs e)
        {
            
        }

        private void B_REGISTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Student:
                    registerStudent = new RegisterStudent();   
                    registerStudent.ShowDialog();
                    break;
                case Role.Lecturer:
                    registerLecturer = new RegisterLecturer();
                    registerLecturer.ShowDialog();
                    break;
            }
            this.Show();
        }

        private void B_CLOSE_Click(object sender, EventArgs e)
        {
            role = Role.None;
            this.Close();
        }

        private void R_ADMIN_CheckedChanged(object sender, EventArgs e)
        {
            this.TableName = "ADMIN";
            this.role = Role.Admin;
        }

        private void R_STUDENT_CheckedChanged(object sender, EventArgs e)
        {
            this.TableName = "STUDENT";
            this.role = Role.Student;
        }

        private void R_LECTURER_CheckedChanged(object sender, EventArgs e)
        {
            this.TableName = "LECTURER";
            this.role = Role.Lecturer;
        }
    }
}
