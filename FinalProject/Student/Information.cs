﻿using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject.Student
{
    public partial class Information : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database DB { get; set; }
        public DataTable User { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string StudentID { get; set; }

        public Information(string studentID)
        {
            InitializeComponent();
            StudentID = studentID;
            FirstLoad();
        }

        public Information(DataTable user)
        {
            InitializeComponent();
            User = user;
            StudentID = User.Rows[0]["ID"].ToString();
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "STUDENT";
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
            FIllData(P_DATA,User);
        }

        public void FIllData(Panel parent, DataTable dataTable)
        {
            foreach(Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    try
                    {
                        control.Text = dataTable.Rows[0][control.Name].ToString();
                    }
                    catch { }
                }
                if(control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (dataTable.Rows[0]["GENDER"].ToString() == "Nam")
                    {
                        comboBox.SelectedIndex = 0;
                    }
                    else if (dataTable.Rows[0]["GENDER"].ToString() == "Nữ")
                    {
                        comboBox.SelectedIndex = 1;
                    }
                }
                if(control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Text = dataTable.Rows[0][control.Name].ToString();
                }
                if(control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    try
                    {
                        pictureBox.BackgroundImage = null;
                        Meta.LoadImage(pictureBox, "avatar\\student", User.Rows[0]["AVATAR"].ToString());
                    }
                    catch
                    {
                        Meta.SetNullImage(pictureBox);
                    }
                }

            }
        }

        public bool CheckDataRefer()
        {
            bool check = true;
            if (!Source.Email.IsValidEmail(EMAIL.Text.Trim()))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Email không hợp lệ!", EMAIL);
                check = false;
            }
            
            return check;
        }

        public bool CheckDataRequire()
        {
            bool check = true;
            if (MSSV.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("MSSV không được để trống!", MSSV);
                check = false;
            }
            if (FIRSTNAME.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Họ và Tên đệm không được để trống!", FIRSTNAME);
                check = false;
            }
            if (LASTNAME.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Tên không được để trống!", LASTNAME);
                check = false;
            }
            if (DateTime.Now.Year - BIRTHDAY.Value.Year < 17)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Năm sinh không hợp lệ!", BIRTHDAY);
                check = false;
            }
            if (GENDER.SelectedIndex == -1)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Chưa chọn giới tính!", GENDER);
                check = false;
            }
            if(EMAIL.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Email không được để trống!", EMAIL);
                check = false;
            }
            if(PHONE.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Số điện thoại không được để trống!", PHONE);
                return false;
            }
            if(ADDRESS.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Địa chỉ không được để trống!", ADDRESS);
                return false;
            }
            if (AVATAR.Image == null)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Ảnh chưa được tải lên!", AVATAR);
                return false;
            }
            
            return check;
        }

        public void GetDataToTable(Panel parent, DataTable dataTable)
        {
            if(dataTable.Rows.Count < 1)
            {
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);
            }
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
                if (control is DateTimePicker)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
                if(control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    dataTable.Columns.Add(comboBox.Name);
                    dataTable.Rows[0][comboBox.Name] = comboBox.Text;
                }
                if(control is PictureBox)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
            }

            dataTable.Columns.Add("ACTIVE");
            dataTable.Rows[0]["ACTIVE"] = 0;
        }

        private void B_CLOSE_Click(object sender, EventArgs e)
        {
            Role = Role.None;
            this.Close();
        }

        private void B_CANCLE_Click(object sender, EventArgs e)
        {
            Role = Role.None;
            this.Close();
        }

        private void AVATAR_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = Path.Combine("avatar", "student");
                AVATAR.Text = Meta.LoadImage(AVATAR, "STD" + MSSV.Text);
                Source.Meta.SaveImage(AVATAR, savePath);
            }
            catch { }
        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void PHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là một số hoặc phím điều hướng
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số hoặc phím điều hướng, hủy sự kiện KeyPress
                e.Handled = true;
            }
            // Giới hạn độ dài của TextBox là 10 ký tự
            if (PHONE.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                // Nếu độ dài vượt quá 10 ký tự và không phải phím điều hướng, hủy sự kiện KeyPress
                e.Handled = true;
            }
        }

        private void FIRSTNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là một số hoặc phím điều hướng
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                // Nếu là số hoặc phím điều hướng, cho phép
                e.Handled = false;
            }
            else
            {
                // Nếu không phải là số hoặc phím điều hướng, không cho phép
                e.Handled = true;
            }
        }

        private void B_UPDATE_Click(object sender, EventArgs e)
        {
            if (!CheckDataRefer())
            {
                return;
            }
            if(!CheckDataRequire())
            {
                return;
            }

            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE {0} ", TableName);
            //=====================================================
            query.AppendFormat("SET MSSV = N'{0}', ", MSSV.Text);
            query.AppendFormat("EMAIL = N'{0}', ", EMAIL.Text);
			query.AppendFormat("FIRSTNAME = N'{0}', ", FIRSTNAME.Text);
            query.AppendFormat("LASTNAME = N'{0}',", LASTNAME.Text);
            query.AppendFormat("BIRTHDAY = N'{0}', ", BIRTHDAY.Text);
            query.AppendFormat("GENDER = N'{0}', ", GENDER.Text);
            query.AppendFormat("PHONE = N'{0}', ", PHONE.Text);
            query.AppendFormat("[ADDRESS] = N'{0}',", ADDRESS.Text);
            query.AppendFormat("AVATAR = N'{0}' ", AVATAR.Text);
            //=======================================================
            query.AppendFormat("WHERE ID = N'{0}'", StudentID);

            using (SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                try
                {
                    DB.Connect();
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành công");
                    DB.Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    DB.Disconnect();
                }
            }
        }

        public DataTable GetStudent(string id)
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM {0} ", TableName);
            query.AppendFormat("WHERE ID = N'{0}'", StudentID);

            using(SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                try
                {
                    DB.Connect();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    DB.Disconnect();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    DB.Disconnect();
                }
            }

            return dt;
        }

        private void B_CHANGEPASSWORD_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(MSSV.Text, FIRSTNAME.Text + " " + LASTNAME.Text);
            changePassword.ShowDialog();
        }
    }
}
