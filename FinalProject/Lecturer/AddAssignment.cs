using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Lecturer
{
    public partial class AddAssignment : Form
    {
        public Database.Database DB { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string LecturerID { get; set; }
        public string CourseID { get; set; }
        public string SourceFile { get; set; }
        public DataTable dtSource { get; set; }

        public AddAssignment()
        {
            InitializeComponent();
        }
        public AddAssignment(string lecturerID, string courseID)
        {
            InitializeComponent();
            LecturerID = lecturerID;
            CourseID = courseID;
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "Assignment";
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
            LECTUREID.Text = LecturerID.Trim();
            COURESID.Text = CourseID.Trim();
        }

        public bool CheckDataRefer()
        {
            bool check = true;
            string toolTip = string.Empty;
            if(!(FILENAME.Text.Trim().EndsWith(".doc") || FILENAME.Text.Trim().EndsWith(".docx")))
            {
                toolTip += "Đuôi file không hợp lệ (doc or docx)!\n";
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

            if (LECTUREID.Text.Trim() == "")
            {
                toolTip += "Mã giang vien bị trống!\n";
                check = false;
            }
            if (COURESID.Text.Trim() == "")
            {
                toolTip += "Mã khóa học bị trống!\n";
                check = false;
            }
            if (FILENAME.Text.Trim() == "")
            {
                toolTip += "Tên file không được để trống!\n";
                check = false;
            }
            if (!check)
            {
                MessageBox.Show(toolTip, "ERROR");
            }
            return check;
        }

        private void B_UPLOAD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Documents|*.doc;*.docx|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    FILENAME.Text = fileName;
                    SourceFile = openFileDialog.FileName;
                }
            }
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
            Meta.UpLoadFile(SourceFile, "assignments", FILENAME.Text);
            GetDataToDataTable();
            DB.Connect();
            DB.InsertRow(dtSource);
            DB.Disconnect();
            this.Close();
        }

        public void GetDataToDataTable()
        {
            dtSource = new DataTable();
            dtSource.Rows.Clear();
            dtSource.Rows.Add(dtSource.NewRow());
            foreach(Control control in P_DATA.Controls)
            {
                if(control is TextBox)
                {
                    dtSource.Columns.Add(control.Name);
                    dtSource.Rows[0][control.Name] = control.Text;
                }
            }

            dtSource.Columns.Add("STUDENTID");
            dtSource.Rows[0]["STUDENTID"] = "";
            dtSource.Columns.Add("SCORE");
            dtSource.Rows[0]["SCORE"] = "";
        }
    }
}
