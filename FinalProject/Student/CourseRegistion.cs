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
    public partial class CourseRegistion : Form
    {
        public string Servername { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database DB { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public CourseRegistion()
        {
            InitializeComponent();
        }
        public CourseRegistion(string StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            FirstLoad();
            
        }
        public void FirstLoad()
        {
            Servername = "localhost";
            DatabaseName = "Final";
            TableName = "COURSE";
            DB = new Database.Database(Servername, DatabaseName, TableName);
            DB.Open();
            DGV_DATA.DataSource = DB.GetTable_VI("");
        }

        public void Reload()
        {

        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            int rowIndex = DGV_DATA.SelectedCells[0].RowIndex; 
            CourseID = DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString();

            TableName = "STUDENT_COURSE";
            DB = new Database.Database(Servername, DatabaseName, TableName);
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            dt.Columns.Add("COURSEID");
            dt.Columns.Add("STUDENTID");
            dt.Columns.Add("SCORE");
            dt.Rows[0]["COURSEID"] = CourseID;
            dt.Rows[0]["STUDENTID"] = StudentID;
            dt.Rows[0]["SCORE"] = "0";
            if (DB.InsertRow(dt))
            {
                this.Close();
            }
        }
    }
}
