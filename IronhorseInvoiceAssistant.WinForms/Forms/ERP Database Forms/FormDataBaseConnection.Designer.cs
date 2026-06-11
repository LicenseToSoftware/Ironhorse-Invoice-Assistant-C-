namespace IronhorseInvoiceAssistant.WinForms.Forms.ERP_Database_Forms
{
    partial class FormDataBaseConnection
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
            lblLocalHost = new Label();
            txtLocalHost = new TextBox();
            lblDatabase = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtDatabase = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnDatabaseConnect = new Button();
            lblSQLPortAddress = new Label();
            txtSQLPortAddress = new TextBox();
            SuspendLayout();
            // 
            // lblLocalHost
            // 
            lblLocalHost.AutoSize = true;
            lblLocalHost.Location = new Point(205, 112);
            lblLocalHost.Name = "lblLocalHost";
            lblLocalHost.Size = new Size(134, 25);
            lblLocalHost.TabIndex = 0;
            lblLocalHost.Text = "SQL IP Address";
            // 
            // txtLocalHost
            // 
            txtLocalHost.Location = new Point(348, 112);
            txtLocalHost.Name = "txtLocalHost";
            txtLocalHost.Size = new Size(150, 31);
            txtLocalHost.TabIndex = 1;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(266, 210);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(90, 25);
            lblDatabase.TabIndex = 2;
            lblDatabase.Text = "Database:";
            lblDatabase.Click += label2_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(283, 254);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(103, 25);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(205, 291);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(362, 210);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(150, 31);
            txtDatabase.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(392, 254);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(302, 291);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 7;
            // 
            // btnDatabaseConnect
            // 
            btnDatabaseConnect.Location = new Point(335, 338);
            btnDatabaseConnect.Name = "btnDatabaseConnect";
            btnDatabaseConnect.Size = new Size(112, 34);
            btnDatabaseConnect.TabIndex = 8;
            btnDatabaseConnect.Text = "button1";
            btnDatabaseConnect.UseVisualStyleBackColor = true;
            btnDatabaseConnect.Click += btnDataBaseConnect_Click;
            // 
            // lblSQLPortAddress
            // 
            lblSQLPortAddress.AutoSize = true;
            lblSQLPortAddress.Location = new Point(222, 164);
            lblSQLPortAddress.Name = "lblSQLPortAddress";
            lblSQLPortAddress.Size = new Size(44, 25);
            lblSQLPortAddress.TabIndex = 9;
            lblSQLPortAddress.Text = "Port";
            // 
            // txtSQLPortAddress
            // 
            txtSQLPortAddress.Location = new Point(362, 161);
            txtSQLPortAddress.Name = "txtSQLPortAddress";
            txtSQLPortAddress.Size = new Size(150, 31);
            txtSQLPortAddress.TabIndex = 10;
            // 
            // FormDataBaseConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSQLPortAddress);
            Controls.Add(lblSQLPortAddress);
            Controls.Add(btnDatabaseConnect);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDatabase);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblDatabase);
            Controls.Add(txtLocalHost);
            Controls.Add(lblLocalHost);
            Name = "FormDataBaseConnection";
            Text = "DataBaseConnection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocalHost;
        private TextBox txtLocalHost;
        private Label lblDatabase;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtDatabase;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnDatabaseConnect;
        private Label lblSQLPortAddress;
        private TextBox txtSQLPortAddress;
    }
}