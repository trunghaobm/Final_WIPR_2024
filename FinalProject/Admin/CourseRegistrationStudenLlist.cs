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

namespace FinalProject.Admin
{
    public partial class CourseRegistrationStudenLlist : Form
    {
        public string ServerName { get; set; } = "localhost";
        public string DatabaseName { get; set; } = "Final";
        public string TableName { get; set; } = "STUDENT";
        public Database.Database DB { get; set; }
        public CourseRegistrationStudenLlist()
        {
            InitializeComponent();
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
            FirstLoad();
        }

        public void FirstLoad()
        {
            DGV_DATA.DataSource = GetStudentList(SEARCH.Text);
        }

        public DataTable GetStudentList(string condition)
        {
            DataTable result = new DataTable();

            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM STUDENT ");
            //=======================
            query.Append("WHERE ");
            //============================
            query.AppendFormat("ID LIKE '%' + N'{0}' + '%' OR ", condition);
            query.AppendFormat("MSSV LIKE '%' + N'{0}' + '%' OR ", condition);
            query.AppendFormat("FIRSTNAME LIKE '%' + N'{0}' + '%' OR ", condition);
            query.AppendFormat("LASTNAME LIKE '%' + N'{0}' + '%' OR ", condition);
            query.AppendFormat("N'{0}' = N'' ", condition);

            using(SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                DB.Connect();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);

                DB.Disconnect();
            }


            return result;
        }

        private void SEARCH_TextChanged(object sender, EventArgs e)
        {
            FirstLoad();
        }

        private void DGV_DATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string studentID = DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString();
            Admin.CourseRegistration courseRegistration = new Admin.CourseRegistration(studentID);
            courseRegistration.ShowDialog();
        }
    }
}
