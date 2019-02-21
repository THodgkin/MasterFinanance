using MasterFinananceUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFinananceUI.Forms
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            RefreshDgrdAccount();
        }

        private void RefreshDgrdAccount()
        {
            dgrdAccounts.Rows.Clear();
            DataTable DT;
            Account a = new Account();
            DT = a.ReadAll();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow dr = DT.Rows[i];
                this.dgrdAccounts.Rows.Add(dr["account_id"], dr["account_name"].ToString()
                    , dr["account_number"].ToString(), dr["routing_number"].ToString(), dr["account_type"].ToString(), dr["website"].ToString());
            }

        }
    }
}
