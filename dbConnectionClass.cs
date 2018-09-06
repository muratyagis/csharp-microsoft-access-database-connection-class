using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;// add other form
using System.Data;//  add other form
using System.Data.OleDb;// add other form

namespace YourProjectName

{
    class DBConnect
    {

        static string databaseName = "/yordatabasename.accdb";
        public static DataSet infoList(string command)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + databaseName);
            conn.Open();
            OleDbCommand query = new OleDbCommand(command, conn);
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            adtr.SelectCommand = query;
            DataSet virtualtable = new DataSet();
            adtr.Fill(virtualtable);
            conn.Close();
            return virtualtable;


        }

        public static void RunCommand(string command)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + databaseName);
            conn.Open();
            OleDbCommand query = new OleDbCommand(command, conn);
            query.ExecuteNonQuery();
            conn.Close();

        }

        public static DataTable tableName()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + databaseName);
            conn.Open();
            DataTable tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            conn.Close();
            return tables;


        }

    }
}
