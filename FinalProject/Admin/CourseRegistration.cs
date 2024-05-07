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
    public partial class CourseRegistration : Form
    {
        public string ServerName { get; set; } = "localhost";
        public string DatabaseName { get; set; } = "Final";
        public string TableName { get; set; } = "STUDENT_COURSE";
        public Database.Database DB { get; set; }
        public DataTable TableStdCrs { get; set; }
        public DataTable TableStudents { get; set; }
        public DataTable TableCourse { get; set; }
        public int AvailablePosition { get; set; } = -1;
        public int SelectedlePosition { get; set; } = -1;

        private BindingList<CourseData> AvailableCourse;
        private BindingList<CourseData> SelectedCourse;
        class CourseData
        {
            public string ID { get; set; }
            public string LABEL { get; set; }
            public CourseData(string id, string label)
            {
                ID = id;
                LABEL = label;
            }

        }

        public CourseRegistration()
        {
            InitializeComponent();
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
            FirstLoad();
        }

        public void FirstLoad()
        {
            AvailableCourse = new BindingList<CourseData>();
            SelectedCourse = new BindingList<CourseData>();
            TableCourse = new DataTable();


            TableCourse = GeLlistCourse();
            //tham khao https://stackoverflow.com/questions/208532/how-do-you-convert-a-datatable-into-a-generic-list
            List<DataRow> courseList = TableCourse.AsEnumerable().ToList();
            foreach (DataRow item in courseList)
            {
                string id = item["ID"].ToString();
                string label = item["LABEL"].ToString();
                CourseData courseData = new CourseData(id, label);
                AvailableCourse.Add(courseData);
            }
            lsbAvailableCourse.DataSource = AvailableCourse;
            lsbAvailableCourse.ValueMember = "ID";
            lsbAvailableCourse.DisplayMember = "LABEL"; //co the chuyen thanh course name hay name
            lsbAvailableCourse.SelectedItem = null;

            lsbSelectedCourse.DataSource = SelectedCourse;
            lsbSelectedCourse.ValueMember = "ID";
            lsbSelectedCourse.DisplayMember = "LABEL"; //co the chuyen thanh course name hay name
            lsbSelectedCourse.SelectedItem = null;
        }

        public void ReLoad() { 

        }

        //tra ve mot bang course
        public DataTable GeLlistCourse()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM COURSE");

            using(SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedCourse == null || AvailablePosition == -1)
                {
                    MessageBox.Show("Please Choose A Course To Add", "Add Course",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Thêm phần tử được chọn vào ListBox đích
                    //lsbSelectedCourse.Items.Add(selectedCourse);
                    SelectedCourse.Add(AvailableCourse[AvailablePosition]);
                    AvailableCourse.RemoveAt(AvailablePosition);
                    AvailablePosition = lsbAvailableCourse.SelectedIndex;
                    if(SelectedlePosition == -1)
                    {
                        SelectedlePosition = 0;
                    }
                    //lsbAvailableCourse.Items.Remove(selectedCourse);
                    // Xóa phần tử đã chọn khỏi ListBox nguồn
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string message = ex.Message;
                MessageBox.Show("No Course Left!", "Add Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void lsbAvailableCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            AvailablePosition = lsbAvailableCourse.SelectedIndex;
        }

        private void lsbSelectedCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedlePosition = lsbSelectedCourse.SelectedIndex;
        }

        private void B_REMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (AvailableCourse == null || SelectedlePosition == -1)
                {
                    MessageBox.Show("Please Choose A Course To Remove", "Remove Course",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Thêm phần tử được chọn vào ListBox đích
                    //lsbSelectedCourse.Items.Add(selectedCourse);
                    AvailableCourse.Add(SelectedCourse[SelectedlePosition]);
                    SelectedCourse.RemoveAt(SelectedlePosition);
                    SelectedlePosition = lsbAvailableCourse.SelectedIndex;
                    if(AvailablePosition == -1)
                    {
                        AvailablePosition = 0;
                    }
                    //lsbAvailableCourse.Items.Remove(selectedCourse);
                    // Xóa phần tử đã chọn khỏi ListBox nguồn
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string message = ex.Message;
                MessageBox.Show("No Course Left!", "Remove Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
