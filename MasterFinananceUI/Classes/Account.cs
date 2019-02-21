using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFinananceUI.Classes
{
    class Account
    {
        public int Id { get; }
        public string AccountName { get; set; }
        public int AccountType { get; set; }
        public string Website { get; set; }

        public Account() { }
        public Account(int Id)
        {
            this.Id = Id;
        }

        public DataTable ReadOne()
        {
            string database = Properties.Settings.Default.databaseName;
            string query = String.Format("SELECT * FROM {0}.dbo.Person WHERE Id = @Id", database);
            string connString = Properties.Settings.Default.connectionString;
            DataTable DT = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(DT);
                return DT;
            }
        }
        public DataTable ReadAll()
        {
            string database = Properties.Settings.Default.databaseName;
            string query = String.Format("SELECT * FROM {0}.dbo.tblAccount", database);
            string connString = Properties.Settings.Default.connectionString;
            DataTable DT = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(DT);
                return DT;
            }
        }
    }
}
