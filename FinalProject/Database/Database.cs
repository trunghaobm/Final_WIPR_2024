using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Database
{
    public class Database
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public SqlConnection Connection { get; set; }

        public Database() {
            ServerName = "";
            DatabaseName = "";
            TableName = "";
            Connection = new SqlConnection();
        }

        public Database(string serverName, string databaseName, string tablename)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            TableName = tablename;
            Connection = new SqlConnection();
        }

        public Database(Database database)
        {
            ServerName = database.ServerName;
            DatabaseName = database.DatabaseName; 
            TableName = database.TableName;
            Connection = new SqlConnection();
        }

        public bool Open()
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("Server={0};", ServerName);
            query.AppendFormat("Database={0};", DatabaseName);
            query.AppendFormat("Integrated Security=True;");
            try
            {
                Connection = new SqlConnection(query.ToString());
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool isConnected()
        {
            return Connection.State == System.Data.ConnectionState.Open;
        }

        public bool isDisConnected()
        {
            return Connection.State == System.Data.ConnectionState.Closed;
        }

        public void Connect() 
        { 
            if(isDisConnected()) { Connection.Open(); }
        }
        public void Disconnect() 
        { 
            if(isConnected()) { Connection.Close(); }
        }

        public DataTable GetTable(string condition)
        {
            Open();
            Connect();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GETTABLE_{0}(N'{1}')", TableName, condition);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), Connection))
            {
                adapter.Fill(dataTable);
            }
            Disconnect();
            // Trả về DataTable chứa dữ liệu
            return dataTable;
        }

        public DataTable GetTable_VI(string condition)
        {
            Open();
            Connect();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GETTABLE_{0}_VI(N'{1}')", TableName, condition);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), Connection))
            {
                adapter.Fill(dataTable);
            }
            Disconnect();
            // Trả về DataTable chứa dữ liệu
            return dataTable;
        }

        public DataTable GetTable_join(string condition)
        {
            Open();
            Connect();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GETTABLE_JOIN_{0}(N'{1}')", TableName, condition);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), Connection))
            {
                adapter.Fill(dataTable);
            }
            Disconnect();
            // Trả về DataTable chứa dữ liệu
            return dataTable;
        }
        public DataTable GetTable_join_VI(string condition)
        {
            Open();
            Connect();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GETTABLE_JOIN_{0}_VI(N'{1}')", TableName, condition);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), Connection))
            {
                adapter.Fill(dataTable);
            }
            Disconnect();
            // Trả về DataTable chứa dữ liệu
            return dataTable;
        }

        public bool InsertRow(DataTable source)
        {
            Open();
            Connect();

            using(SqlCommand command = new SqlCommand(String.Format("INSERT_{0}", TableName), Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                for(int i = 0;i< source.Columns.Count; i++)
                {
                    command.Parameters.AddWithValue(String.Format("@{0}", source.Columns[i].ColumnName), source.Rows[0][i]);
                }
                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Disconnect();
            return false;
        }
        public bool UpdatetRow(DataTable source)
        {
            Open();
            Connect();

            using (SqlCommand command = new SqlCommand(String.Format("UPDATE_{0}", TableName), Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < source.Columns.Count; i++)
                {
                    command.Parameters.AddWithValue(String.Format("@{0}", source.Columns[i].ColumnName), source.Rows[0][i]);
                }
                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Disconnect();
            return false;
        }
        public bool DeletetRow(DataTable source)
        {
            Open();
            Connect();

            using (SqlCommand command = new SqlCommand(String.Format("DELETE_{0}", TableName), Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                //parmeter:ID
                command.Parameters.AddWithValue(String.Format("@{0}", source.Columns[0].ColumnName), source.Rows[0][0]);
                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Disconnect();
            return false;
        }
    }
}
