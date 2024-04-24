using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Student
{
    public partial class CourseManagement : Form
    {
        public string Servername { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database DB { get; set; }
        public CourseRegistion CourseRegistionForm { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public CourseManagement()
        {
            InitializeComponent();
            FirstLoad();
        }
        public CourseManagement(string StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            FirstLoad();
        }

        public void FirstLoad()
        {
            Servername = "localhost";
            DatabaseName = "Final";
            TableName = "STUDENT_COURSE";
            DB = new Database.Database(Servername, DatabaseName, TableName);
            DB.Open();
            DGV_DATA.DataSource = DB.GetTable_join_VI(StudentID);
            CourseRegistionForm = new CourseRegistion(StudentID);            
        }

        public void Reload()
        {
            DGV_DATA.DataSource = DB.GetTable_join_VI(StudentID);
        }

        private void B_SEARCH_Click(object sender, EventArgs e)
        {

        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            CourseRegistionForm.ShowDialog();
            Reload();
        }

        private void B_RELOAD_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void B_REMOVE_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa?","Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                DataTable dt = new DataTable();
                dt.Rows.Add(dt.NewRow());
                dt.Columns.Add("ID");
                dt.Rows[0]["ID"] = DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString();
                try
                {
                    DB.DeletetRow(dt);
                    MessageBox.Show("Đã xóa!");
                    Reload();
                }
                catch (Exception ex)
                {
                    TableName = "COURSE";
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
