using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Login
{
    public partial class RegisterLecturer : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database database { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }

        public RegisterLecturer()
        {
            InitializeComponent();
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "LECTURER";
            database = new Database.Database(ServerName, DatabaseName, TableName);
            database.Open();
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
            if (!Source.Email.IsValidPassword(PASSWORD.Text))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Mật khẩu phải chứa các ký tự A-Z, a-z, 0-9\nvà một ký tự đặc biệt!", PASSWORD);
                check = false;
            }
            if (PASSWORD.Text != PASSWORDRE.Text)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Mật khẩu không trùng khớp!", PASSWORDRE);
                check = false;
            }
            return check;
        }

        public bool CheckDataRequire()
        {
            bool check = true;
            if (FACTORY.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Khoa không được để trống!", FACTORY);
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
            if (EMAIL.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Email không được để trống!", EMAIL);
                check = false;
            }
            if (PHONE.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Số điện thoại không được để trống!", PHONE);
                return false;
            }
            if (ADDRESS.Text.Trim() == "")
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
            if (PASSWORD.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Mật khẩu không được để trống!", PASSWORD);
                check = false;
            }
            if (PASSWORDRE.Text.Trim() == "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Chưa nhập lại mật khẩu!", PASSWORDRE);
                check = false;
            }
            return check;
        }

        private void B_REGISTER_Click(object sender, EventArgs e)
        {
            if (!CheckDataRequire())
            {
                return;
            }
            if (!CheckDataRefer())
            {
                return;
            }

            database.Connect();

            DataTable dtSource = new DataTable();
            GetDataToTable(P_DATA, dtSource);

            if (database.InsertRow(dtSource))
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi không thể đăng ký!");
            }

            database.Disconnect();
        }

        public void GetDataToTable(Panel parent, DataTable dataTable)
        {
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox && control != PASSWORDRE)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
                if (control is DateTimePicker)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    dataTable.Columns.Add(comboBox.Name);
                    dataTable.Rows[0][comboBox.Name] = comboBox.Text;
                }
                if (control is PictureBox)
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
            string savePath = Path.Combine("avatar", "lecturer");
            AVATAR.Text = Meta.LoadImage(AVATAR, "LEC_" + Meta.RandomString(20));
            Source.Meta.SaveImage(AVATAR, savePath);
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
    }
}
