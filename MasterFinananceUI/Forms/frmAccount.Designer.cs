namespace MasterFinananceUI.Forms
{
    partial class frmAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgrdAccounts = new System.Windows.Forms.DataGridView();
            this.lblDgrdAccounts = new System.Windows.Forms.Label();
            this.hAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRoutingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountAbbrev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOpeningDate = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdAccounts
            // 
            this.dgrdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hAccountId,
            this.hAccountName,
            this.hAccountNumber,
            this.hRoutingNumber,
            this.hAccountType,
            this.hWebsite});
            this.dgrdAccounts.Location = new System.Drawing.Point(13, 193);
            this.dgrdAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrdAccounts.MultiSelect = false;
            this.dgrdAccounts.Name = "dgrdAccounts";
            this.dgrdAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdAccounts.Size = new System.Drawing.Size(994, 287);
            this.dgrdAccounts.TabIndex = 0;
            // 
            // lblDgrdAccounts
            // 
            this.lblDgrdAccounts.AutoSize = true;
            this.lblDgrdAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgrdAccounts.Location = new System.Drawing.Point(12, 169);
            this.lblDgrdAccounts.Name = "lblDgrdAccounts";
            this.lblDgrdAccounts.Size = new System.Drawing.Size(71, 20);
            this.lblDgrdAccounts.TabIndex = 1;
            this.lblDgrdAccounts.Text = "Accounts";
            // 
            // hAccountId
            // 
            this.hAccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hAccountId.HeaderText = "Account ID";
            this.hAccountId.Name = "hAccountId";
            this.hAccountId.ReadOnly = true;
            // 
            // hAccountName
            // 
            this.hAccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hAccountName.HeaderText = "Account";
            this.hAccountName.Name = "hAccountName";
            this.hAccountName.ReadOnly = true;
            this.hAccountName.Width = 83;
            // 
            // hAccountNumber
            // 
            this.hAccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hAccountNumber.HeaderText = "Account Number";
            this.hAccountNumber.Name = "hAccountNumber";
            this.hAccountNumber.ReadOnly = true;
            this.hAccountNumber.Width = 125;
            // 
            // hRoutingNumber
            // 
            this.hRoutingNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hRoutingNumber.HeaderText = "Routing Number";
            this.hRoutingNumber.Name = "hRoutingNumber";
            this.hRoutingNumber.Width = 123;
            // 
            // hAccountType
            // 
            this.hAccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hAccountType.HeaderText = "Account Type";
            this.hAccountType.Name = "hAccountType";
            this.hAccountType.ReadOnly = true;
            this.hAccountType.Width = 105;
            // 
            // hWebsite
            // 
            this.hWebsite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hWebsite.HeaderText = "Website";
            this.hWebsite.Name = "hWebsite";
            this.hWebsite.ReadOnly = true;
            this.hWebsite.Width = 82;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(13, 57);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 25);
            this.txtAccountName.TabIndex = 2;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(16, 38);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(41, 17);
            this.lblAccountName.TabIndex = 3;
            this.lblAccountName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // txtAccountAbbrev
            // 
            this.txtAccountAbbrev.Location = new System.Drawing.Point(119, 57);
            this.txtAccountAbbrev.Name = "txtAccountAbbrev";
            this.txtAccountAbbrev.Size = new System.Drawing.Size(100, 25);
            this.txtAccountAbbrev.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(326, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 25);
            this.textBox6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(474, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 25);
            this.textBox7.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(770, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(851, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(932, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtOpeningDate
            // 
            this.txtOpeningDate.Location = new System.Drawing.Point(667, 81);
            this.txtOpeningDate.Name = "txtOpeningDate";
            this.txtOpeningDate.Size = new System.Drawing.Size(100, 25);
            this.txtOpeningDate.TabIndex = 19;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 493);
            this.Controls.Add(this.txtOpeningDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountAbbrev);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblDgrdAccounts);
            this.Controls.Add(this.dgrdAccounts);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAccount";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdAccounts;
        private System.Windows.Forms.Label lblDgrdAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRoutingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hWebsite;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountAbbrev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox txtOpeningDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}