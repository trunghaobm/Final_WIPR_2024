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
using FinalProject.Database;
using System.Xml.Linq;
using FinalProject.Source;
using Microsoft.Office.Interop.Excel;

namespace FinalProject.Admin
{
    public partial class StudentManager : Form
    {
        public string ServerName { get; set; } = "localhost";
        public string DatabaseName { get; set; } = "Final";
        public string TableName { get; set; } = "Student";
        public Database.Database DB { get; set; }
        public StudentManager()
        {
            InitializeComponent();
            FirstLoad();
        }

        public void FirstLoad()
        {
            DB = new Database.Database(ServerName,DatabaseName,TableName);
            DB.Open();
            B_UPDATE.Enabled = false;
            B_REMOVE.Enabled = false;
        }

        public void ReLoad()
        {

        }
        public bool CheckDataRefer()
        {
            bool check = true;
            string toolTip = string.Empty;
            if (!Source.Email.IsValidEmail(EMAIL.Text.Trim()))
            {
                toolTip += "Email không hợp lệ!\n";
                check = false;
            }
            if (!check)
            {
                MessageBox.Show(toolTip, "ERROR");
            }
            return check;
        }

        public bool CheckDataRequire()
        {
            bool check = true;
            string toolTip = string.Empty;
            if (MSSV.Text.Trim() == "")
            {
                toolTip += "MSSV không được để trống!\n";
                check = false;
            }
            if (FIRSTNAME.Text.Trim() == "")
            {
                toolTip += "Họ và Tên đệm không được để trống!\n";
                check = false;
            }
            if (LASTNAME.Text.Trim() == "")
            {
                toolTip += "Tên không được để trống!\n";
                check = false;
            }
            if (DateTime.Now.Year - BIRTHDAY.Value.Year < 17)
            {
                toolTip += "Năm sinh không hợp lệ(age < 17)!\n";
                check = false;
            }
            if (EMAIL.Text.Trim() == "")
            {
                toolTip += "Email không được để trống!\n";
                check = false;
            }
            if (PHONE.Text.Trim() == "")
            {
                toolTip += "Số điện thoại không được để trống!\n";
                check = false;
            }
            if (ADDRESS.Text.Trim() == "")
            {
                toolTip += "Địa chỉ không được để trống!\n";
                check = false;
            }
            if (AVATAR.Image == null)
            {
                toolTip += "Ảnh chưa được tải lên!\n";
                check = false;
            }
            if (!check)
            {
                MessageBox.Show(toolTip, "ERROR");
            }
            return check;
        }

        private void B_IMPORT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.Title = "Select an Excel File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                // Khởi tạo ứng dụng Excel
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // Lấy Sheet đầu tiên

                Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                System.Data.DataTable dt = new System.Data.DataTable();

                // Thêm các cột vào DataTable
                for (int i = 1; i <= colCount; i++)
                {
                    dt.Columns.Add(Convert.ToString(excelRange.Cells[1, i].Value2), typeof(string));
                }

                // Thêm dữ liệu từ Excel vào DataTable
                for (int i = 2; i <= rowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    for (int j = 1; j <= colCount; j++)
                    {
                        row[j - 1] = Convert.ToString(excelRange.Cells[i, j].Value2);
                    }
                    row["Email"] = row["MSSV"].ToString() + "@student.hcmute.edu.vn";
                    row["Password"] = Meta.PasswordGenerate(10);
                    row["Phone"] = Meta.GeneratePhoneNumber(10);
                    row["Gender"] = " ";
                    row["Avatar"] = " ";
                    if (Meta.IsVietnameseName(row["FirstName"].ToString()) &&
                        Meta.IsVietnameseName(row["LastName"].ToString()))
                    {
                        dt.Rows.Add(row);
                    }
                }


                // Hiển thị DataTable trong DataGridView
                DGV_LIST.DataSource = dt;
                B_OK_IMPORT.Visible = true;

                // Đóng các đối tượng Excel
                excelWorkbook.Close();
                excelApp.Quit();
            }
        }

        private void B_RELOAD_Click(object sender, EventArgs e)
        {
            B_OK_IMPORT.Visible = false;

            StringBuilder connectionString = new StringBuilder();
            connectionString.AppendFormat("Data Source={0};", ServerName);
            connectionString.AppendFormat("Initial Catalog={0};", DatabaseName);
            connectionString.Append("Integrated Security=True;");

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString.ToString()))
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu truy vấn SQL
                StringBuilder query = new StringBuilder();
                query.AppendFormat("SELECT * FROM {0}", TableName);

                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    // Tạo đối tượng DataTable để chứa dữ liệu từ bảng
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    // Hiển thị DataTable trong DataGridView
                    DGV_LIST.DataSource = dataTable;
                }
            }
        }

        private void B_OK_IMPORT_Click(object sender, EventArgs e)
        {
            SaveDataFromDataGridViewToDatabase();
            B_OK_IMPORT.Visible = false;
        }

        private void SaveDataFromDataGridViewToDatabase()
        {
            System.Data.DataTable dtSource = new System.Data.DataTable();
            foreach (DataGridViewColumn column in DGV_LIST.Columns)
            {
                dtSource.Columns.Add(column.Name);
            }


            // Lặp qua từng dòng trong DataGridView để lưu dữ liệu vào cơ sở dữ liệu
            foreach (DataGridViewRow row in DGV_LIST.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới
                if (!row.IsNewRow)
                {
                    DataRow newRow = dtSource.NewRow();
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        newRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtSource.Rows.Add(newRow);
                    DB.TableName = "Student";
                    DB.InsertRow(dtSource);
                    dtSource.Rows.RemoveAt(0);                    
                }
            }

            // Thông báo khi lưu dữ liệu thành công
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            if (!CheckDataRequire())
            {
                return;
            }
            if (!CheckDataRefer())
            {
                return;
            }

            DB.Connect();

            System.Data.DataTable dtSource = new System.Data.DataTable();
            GetDataToTable(P_INFORMATION, dtSource);

            if (DB.InsertRow(dtSource))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi không thể đăng ký!");
            }

            DB.Disconnect();
        }

        public void GetDataToTable(Panel parent, System.Data.DataTable dataTable)
        {
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
            foreach (Control control in parent.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
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
                if (control is RichTextBox)
                {
                    dataTable.Columns.Add(control.Name);
                    dataTable.Rows[0][control.Name] = control.Text;
                }
                if(control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        dataTable.Columns.Add("GENDER");
                        dataTable.Rows[0]["GENDER"] = radioButton.Text;
                    }
                }
            }

            string password = Meta.PasswordGenerate(10);
            dataTable.Columns.Add("PASSWORD");
            dataTable.Rows[0]["PASSWORD"] = password;

            dataTable.Columns.Add("ACTIVE");
            dataTable.Rows[0]["ACTIVE"] = 0;
            MessageBox.Show("Password is: " + password);
        }

        private void AVATAR_Click(object sender, EventArgs e)
        {
            string savePath = Path.Combine("avatar", "student");
            AVATAR.Text = Meta.LoadImage(AVATAR, "STD" + MSSV.Text);
            Source.Meta.SaveImage(AVATAR, savePath);
        }

        private void MSSV_TextChanged(object sender, EventArgs e)
        {
            if(MSSV.Text.Trim() == "")
            {
                EMAIL.Text = "";
            }
            else
            {
                EMAIL.Text = MSSV.Text + "@student.hcmute.edu.vn";
            }
        }
    }
}
