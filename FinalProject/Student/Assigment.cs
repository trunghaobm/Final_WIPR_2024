using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Student
{
    public partial class Assignment : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database DB { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Course.Main coursemanager { get; set; }
        public string StudentID { get; set; }

        public Assignment(string studentID)
        {
            StudentID = studentID;
            InitializeComponent();
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "ASSIGNMENT";
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
            Reload();
        }

        public DataTable Search(string condition)
        {
            DB.Open();
            DB.Connect();

            StringBuilder query = new StringBuilder();
            //query.AppendFormat("SELECT * FROM GETTABLE_JOIN_{0}_VI(N'{1}')", TableName, condition);
            query.Append("SELECT A.ID AS ID, ");
            //query.Append("A.LECTUREID AS [MÃ GIẢNG VIÊN], ");
            //query.Append("L.FIRSTNAME AS [HỌ GV], ");
            //query.Append("L.LASTNAME  AS [TÊN GV], ");
            //query.Append("A.STUDENTID AS [MÃ SINH VIÊN], ");
            //query.Append("S.FIRSTNAME AS [HỌ SV], ");
            //query.Append("S.LASTNAME  AS [TÊN SV], ");
            query.Append("A.COURESID  AS [MÃ MÔN HỌC], ");
            query.Append("C.LABEL  AS [TÊN MÔN HỌC], ");
            query.Append("A.[FILENAME] AS [TÊN FILE], ");
            query.Append("A.SUBMIT AS [TÌNH TRẠNG], ");
            query.Append("A.SCORE    AS [ĐIỂM] ");
           //================================================================
            query.Append("FROM ASSIGNMENT A ");
            query.Append("LEFT JOIN LECTURER L ON A.LECTUREID = L.ID ");
            query.Append("LEFT JOIN STUDENT S ON A.STUDENTID = S.ID ");
            query.Append("LEFT JOIN COURSE C ON A.COURESID = C.ID ");
            //==============================================================
            query.AppendFormat("WHERE A.STUDENTID = N'{0}'", condition);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), DB.Connection))
            {
                adapter.Fill(dataTable);
            }
            DB.Disconnect();

            return dataTable;
        }

        public void Reload()
        {
            DGV_DATA.DataSource = Search(StudentID);
            DGV_DATA.Sort(DGV_DATA.Columns["MÃ MÔN HỌC"], ListSortDirection.Ascending);
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            
        }

        private void B_SEARCH_Click(object sender, EventArgs e)
        {
            DGV_DATA.DataSource = Search(SEARCH.Text.Trim());
        }

        private void B_DOWNLOAD_DOC_Click(object sender, EventArgs e)
        {
            if(DGV_DATA.SelectedCells.Count == 1)
            {
                int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                string fileName = DGV_DATA.Rows[rowIndex].Cells["TÊN FILE"].Value.ToString();
                DialogResult result = MessageBox.Show("Xác nhận tải tài liệu", "Download document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.InitialDirectory = "c:\\"; // Thư mục mặc định để mở
                    saveFileDialog.Filter = "Word document(*.doc, *.docx) |*.doc; *.docx"; // Bộ lọc cho các loại file
                    saveFileDialog.FileName = fileName;
                    saveFileDialog.DefaultExt = ".docx";
                    saveFileDialog.RestoreDirectory = true;

                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string distFile = saveFileDialog.FileName;
                        Meta.DownloadFile("assignments", fileName, distFile);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ được chọn một dòng");
            }
        }

        private void B_SUBMIT_ASSIGNMENT_Click(object sender, EventArgs e)
        {
            if (DGV_DATA.SelectedCells.Count == 1)
            {
                int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                string courseID = DGV_DATA.Rows[rowIndex].Cells["MÃ MÔN HỌC"].Value.ToString();
                string assignmentID = DGV_DATA.Rows[rowIndex].Cells["ID"].Value.ToString();
                string destDir = Path.Combine("Submit", assignmentID, StudentID);
                bool submit = Boolean.Parse(DGV_DATA.Rows[rowIndex].Cells["TÌNH TRẠNG"].Value.ToString());
                if (!submit)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Word document(*.doc, *.docx) |*.doc; *.docx"; 

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string srcFile = openFileDialog.FileName;
                        Meta.UpLoadFile(srcFile, destDir, fileName);
                        UpdateSubmit(assignmentID);
                        MessageBox.Show("Đã nộp");
                        Reload();
                    }
                }
                else
                {
                    DialogResult result =  MessageBox.Show("Bạn đã nộp bài này!\nBạn có muốn sửa bài?", "Submit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "Word document(*.doc, *.docx) |*.doc, *.docx"; // Bộ lọc cho các loại file
                                                                                               //openFileDialog.FileName = fileName;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = Path.GetFileName(openFileDialog.FileName);
                            string srcFile = openFileDialog.FileName;
                            string appPath = Application.StartupPath;
                            File.Delete(Path.Combine(appPath, destDir));
                            Meta.UpLoadFile(srcFile, destDir, fileName);
                            MessageBox.Show("Đã nộp");
                            Reload();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ được chọn một dòng");
            }
        }

        public void UpdateSubmit(string assignmentID)
        {
            DB.Open();
            DB.Connect();

            StringBuilder query = new StringBuilder();
            query.Append("UPDATE ASSIGNMENT ");
            query.Append("SET SUBMIT = 1 ");
            query.AppendFormat("WHERE ID = N'{0}'",assignmentID);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), DB.Connection))
            {
                adapter.Fill(dataTable);
            }
            DB.Disconnect();
        }

        private void B_RELOAD_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
