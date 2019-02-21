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
using System.Text.RegularExpressions;

namespace MasterFinananceUI.Forms
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            loadingCircle.Active = true;
            loadingCircle.Visible = true;
            string server = txtServer.Text;
            string connString = String.Format("Data Source={0};Initial Catalog=master;Integrated Security=True;", server);

            Properties.Settings.Default.connectionString = connString;
            Properties.Settings.Default.Save();


            if (IsValidConnectionString(connString) == true)
            {
                this.btnServerConnect.Visible = false;
                this.txtServer.Enabled = false;
                this.lblDatabase.Visible = true;
                this.txtDatabase.Visible = true;
            }
            loadingCircle.Active = false;
            loadingCircle.Visible = false;
        }

        private bool IsValidConnectionString(string connString)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string connectionStatus = conn.State.ToString();

                if (connectionStatus == "Open")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {

            string server = txtServer.Text;
            string dataBase = txtDatabase.Text;
            string connString = Properties.Settings.Default.connectionString;
            string query = String.Format("CREATE DATABASE {0}", dataBase);

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            connString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", server, dataBase);

            Properties.Settings.Default.databaseName = "[" + dataBase + "]";
            Properties.Settings.Default.connectionString = connString;
            Properties.Settings.Default.Save();
            txtDatabase.Enabled = false;
            btnCreateDB.Visible = false;
            btnSelectDB.Visible = false;
            label1.Visible = true;
            label1.Text = String.Format("You have created your database named {0}", dataBase);
        }
        private void btnSelectDB_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string dataBase = txtDatabase.Text;
            string connString = Properties.Settings.Default.connectionString;
            string query = String.Format("CREATE DATABASE {0}", dataBase);

            connString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", server, dataBase);

            Properties.Settings.Default.databaseName = "[" + dataBase + "]";
            Properties.Settings.Default.connectionString = connString;
            Properties.Settings.Default.Save();
            txtDatabase.Enabled = false;
            btnCreateDB.Visible = false;
            btnSelectDB.Visible = false;
            label1.Visible = true;
            label1.Text = String.Format("You have sucessfully connected to {0}", dataBase);

        }
        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            string dbName = txtDatabase.Text;
            string query = "SELECT COUNT(*) FROM sys.databases DBs WHERE DBs.name = @database";
            string connString = Properties.Settings.Default.connectionString;

            if (dbName.Length > 0)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@database", dbName);
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowCount >= 1)
                    {
                        btnCreateDB.Visible = false;
                        btnSelectDB.Visible = true;
                    }
                    else
                    {
                        btnCreateDB.Visible = true;
                        btnSelectDB.Visible = false;
                    }
                }
            }
            else
            {
                btnCreateDB.Visible = false;
                btnSelectDB.Visible = false;
            }
        }
    }
}
