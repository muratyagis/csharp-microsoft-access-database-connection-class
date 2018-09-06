using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;// diğer formlara ekleyin
using System.Data;// diğer formlara ekleyin
using System.Data.OleDb;// diğer formlara ekleyin

namespace WindowsProjeAdınız
{
    class VTBaglan
    {

        static string veriTabaniAdi = "/veritabaniadi.accdb";
        public static DataSet bilgiListele(string komut)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath +veriTabaniAdi );
            baglan.Open();
            OleDbCommand sorgu = new OleDbCommand(komut, baglan);
            OleDbDataAdapter uygula = new OleDbDataAdapter();
            uygula.SelectCommand = sorgu;
            DataSet sanaltablo = new DataSet();
            uygula.Fill(sanaltablo);
            baglan.Close();
            return sanaltablo;
           
        
        }

        public static void komutisle(string komut)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + veriTabaniAdi);
            baglan.Open();
            OleDbCommand sorgu = new OleDbCommand(komut, baglan);
            sorgu.ExecuteNonQuery();
            baglan.Close();
        
        }

        public static DataTable tabloAdi()
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + veriTabaniAdi);
            baglan.Open();
            DataTable tables = baglan.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
           
            baglan.Close();
            return tables;


        }

    }
}
