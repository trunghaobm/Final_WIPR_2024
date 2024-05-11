using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Course
{
    public partial class Main : Form
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public Database.Database Database { get; set; }
        public string Mode { get; set; } = "show";
        /// <summary>
        /// this is id for assignment
        /// </summary>
        public string ID { get; set; }
        public Main()
        {
            InitializeComponent();
            FirstLoad();
        }

        public Main(string mode)
        {
            InitializeComponent();
            Mode = mode;
            FirstLoad();
        }

        public void FirstLoad()
        {
            ServerName = "localhost";
            DatabaseName = "Final";
            TableName = "COURSE";
            Database = new Database.Database(ServerName, DatabaseName, TableName);
            DGV_DATA.DataSource = Database.GetTable_VI("");
        }

        public void ReLoad()
        {
            DGV_DATA.DataSource = Database.GetTable_VI("");
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            AddNew addnew = new AddNew();
            addnew.ShowDialog();
            ReLoad();
        }

        private void B_UPDATE_Click(object sender, EventArgs e)
        {
            switch (DGV_DATA.SelectedCells.Count)
            {
                case 0: MessageBox.Show("Chưa chọn môn học để sửa"); break;
                case 1:
                    DataTable source = new DataTable();
                    DataRow newrow = source.NewRow();
                    int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                    foreach (DataGridViewColumn column in DGV_DATA.Columns)
                    {
                        source.Columns.Add(column.Name);
                    }
                    foreach (DataGridViewCell cell in DGV_DATA.Rows[rowIndex].Cells)
                    {
                        newrow[cell.OwningColumn.Name] = cell.Value.ToString();
                    }
                    source.Rows.Add(newrow);

                    Update update = new Update(source);
                    update.ShowDialog();
                    ReLoad();
                    break;

                default: MessageBox.Show("Chọn quá nhiều hàng!"); break;
            }
        }

        private void B_REMOVE_Click(object sender, EventArgs e)
        {
            List<string> IDs = new List<string>();
            foreach (DataGridViewCell cell in DGV_DATA.SelectedCells)
            {
                int rowIndex = cell.RowIndex;
                IDs.Add(DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString());
            }
            if (IDs.Count < 1)
            {
                MessageBox.Show("Chưa chọn khóa học!");
                return;
            }
            string stringQuestion = "Xác nhận xóa:\n";
            foreach (string id in IDs)
            {
                stringQuestion += id + '\n';
            }
            DialogResult result = MessageBox.Show(stringQuestion, "Xóa khóa học?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (string id in IDs)
                {
                    Database.DeletetRow(Database.GetTable(id));
                    ReLoad();
                }
            }
            else
            {

            }
        }

        private void B_SEARCH_Click(object sender, EventArgs e)
        {
            DGV_DATA.DataSource = Database.GetTable(SEARCH.Text);
        }

        private void DGV_DATA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Mode.ToLower() == "assignment"){
                int rowIndex = DGV_DATA.SelectedCells[0].RowIndex;
                ID = DGV_DATA.Rows[rowIndex].Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
