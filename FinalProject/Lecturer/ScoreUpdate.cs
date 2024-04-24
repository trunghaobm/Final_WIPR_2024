using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Lecturer
{
    public partial class ScoreUpdate : Form
    {
        public Role Role { get; set; } = Role.None;
        public Database.Database DB { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }

        public string studentName { get; set; }
        public string courseName { get; set; }
        public string ID { get; set; }

        public ScoreUpdate()
        {
            InitializeComponent();
            FirstLoad();
        }
        public ScoreUpdate(string id)
        {
            InitializeComponent();
            ID = id;
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "STUDENT_COURSE";
            DB = new Database.Database(ServerName, DatabaseName, TableName);
            DB.Open();
        }

        private void B_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            string regex = @"^(?:[0-9](?:\.[0-9])?|10(?:\.0)?|0(?:\.[0-9])?)$";
            if (Regex.IsMatch(SCORE.Text, regex))
            {
                DB.Open();
                DB.Connect();

                StringBuilder query = new StringBuilder();
                query.AppendFormat("UPDATE {0} SET SCORE = N'{1}' WHERE ID = N'{2}'", TableName, SCORE.Text, ID);
                try
                {
                    SqlCommand cmd = new SqlCommand(query.ToString(), DB.Connection);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Đã sửa điểm!");
                    this.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DB.Disconnect();
            }
            else
            {
                MessageBox.Show("Nhập sai định dạng!!!");
            }
        }

        private void SCORE_TextChanged(object sender, EventArgs e)
        {
        }

        private void ScoreUpdate_Shown(object sender, EventArgs e)
        {
            L_NAME.Text = studentName;
            L_COURSE.Text = courseName;
        }

        private void SCORE_KeyPress(object sender, KeyPressEventArgs e)
        {
            string regex = @"^\d*(\.\d*)?$";
            string newtext = SCORE.Text + e.KeyChar;
            if (Regex.IsMatch(newtext, regex) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled= true;
            }
        }
    }
}
