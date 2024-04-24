using FinalProject.Lecturer;
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

namespace FinalProject.Course
{
    public partial class ResultManager : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database DB { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }

        public ResultManager()
        {
            InitializeComponent();
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "STUDENT_COURSE";
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
            DGV_DATA.DataSource = Search(NAMEKEY.Text);
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
    }
}
