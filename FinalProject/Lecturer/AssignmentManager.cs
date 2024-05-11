using FinalProject.Source;
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

namespace FinalProject.Lecturer
{
    public partial class AssignmentManager : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database DB { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Course.Main coursemanager { get; set; }

        public AssignmentManager()
        {
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
            query.AppendFormat("SELECT * FROM GETTABLE_JOIN_{0}_VI(N'{1}')", TableName, condition);
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
            DGV_DATA.DataSource = Search("");
        }

        private void NAMEKEY_TextChanged(object sender, EventArgs e)
        {
            DGV_DATA.DataSource = Search(SEARCH.Text);
        }

        private void B_EDIT_SCORE_Click(object sender, EventArgs e)
        {
            int rowindex = DGV_DATA.SelectedCells[0].RowIndex;
            string id = DGV_DATA.Rows[rowindex].Cells["ID"].Value.ToString();
            string stdName = DGV_DATA.Rows[rowindex].Cells["HỌ VÀ TÊN ĐỆM"].Value.ToString() + " " +
                             DGV_DATA.Rows[rowindex].Cells["TÊN"].Value.ToString();
            string courseName = DGV_DATA.Rows[rowindex].Cells["TÊN KHÓA HỌC"].Value.ToString();

            ScoreUpdate scoreUpdate = new ScoreUpdate(id);
            scoreUpdate.studentName = stdName;
            scoreUpdate.courseName = courseName;
            scoreUpdate.ShowDialog();
            Reload();
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            coursemanager = new Course.Main("assignment");
            coursemanager.FormBorderStyle = FormBorderStyle.Sizable;
            coursemanager.Text = "Chọn môn học";
            DialogResult dialogResult = coursemanager.ShowDialog();
            try
            {
                if (dialogResult != DialogResult.Cancel)
                {
                    string courseID = coursemanager.ID;
                    if (courseID != "")
                    {
                        int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                        string lecturerID = DGV_DATA.Rows[rowIndex].Cells["MÃ GIẢNG VIÊN"].Value.ToString();
                        AddAssignment addAssignment = new AddAssignment(lecturerID, courseID);
                        addAssignment.ShowDialog();
                        FirstLoad();
                    }
                }
            }
            catch { }
        }

        private void B_SEARCH_Click(object sender, EventArgs e)
        {
            DGV_DATA.DataSource = Search(SEARCH.Text.Trim());
        }

        private void B_UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void B_REMOVE_Click(object sender, EventArgs e)
        {
            int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
            string assignmentID = DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["ID"] = assignmentID;

            DB.Connect();

            if (DB.DeletetRow(dt))
            {
                MessageBox.Show("Đã xóa");
            }

            DB.Disconnect();
            Reload();
        }
    }
}
