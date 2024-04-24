using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class Test
    {
        public Database DB { get; set; }
        public DataTable dtSource {  get; set; }
        public Test(Database database)
        {
            DB = database;
            dtSource = new DataTable();
        }

        public void Insert()
        {
            DB.Open();
            DB.Connect();

            dtSource.Columns.Add("Email");
            dtSource.Columns.Add("Password");
            dtSource.Columns.Add("Active");

            DataRow dr = dtSource.NewRow();
            dr["Email"] = "admin123@admin.com";
            dr["Password"] = "admin@123456789";
            dr["Active"] = 1;

            dtSource.Rows.Add(dr);

            DB.InsertRow(dtSource);

            DB.Disconnect();
        }

        public void Update()
        {
            DB.Open();
            DB.Connect();

            dtSource.Columns.Add("ID");
            dtSource.Columns.Add("Email");
            dtSource.Columns.Add("Password");
            dtSource.Columns.Add("Active");

            DataRow dr = dtSource.NewRow();
            dr["ID"] = "ACC00000001";
            dr["Email"] = "admi3@admin.com";
            dr["Password"] = "admin@123456789";
            dr["Active"] = 1;

            dtSource.Rows.Add(dr);

            DB.UpdatetRow(dtSource);

            DB.Disconnect();
        }
        public void Delete()
        {
            DB.Open();
            DB.Connect();

            dtSource.Columns.Add("ID");
            dtSource.Columns.Add("Email");
            dtSource.Columns.Add("Password");
            dtSource.Columns.Add("Active");

            DataRow dr = dtSource.NewRow();
            dr["ID"] = "ACC00000001";
            dr["Email"] = "admi3@admin.com";
            dr["Password"] = "admin@123456789";
            dr["Active"] = 1;

            dtSource.Rows.Add(dr);

            DB.DeletetRow(dtSource);

            DB.Disconnect();
        }
    }
}
