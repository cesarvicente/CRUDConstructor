namespace CRUDConstructor
{
    partial class formConnection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcConnectionDB = new TabControl();
            tpParameters = new TabPage();
            nudPort = new NumericUpDown();
            lblPort = new Label();
            lblDataBase = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            btConnect = new Button();
            lblHostname = new Label();
            txtDataBase = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtHostname = new TextBox();
            txtConnectionName = new TextBox();
            lblName = new Label();
            btOk = new Button();
            btCancel = new Button();
            btSave = new Button();
            tbcConnectionDB.SuspendLayout();
            tpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            SuspendLayout();
            // 
            // tbcConnectionDB
            // 
            tbcConnectionDB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbcConnectionDB.Controls.Add(tpParameters);
            tbcConnectionDB.Location = new Point(14, 41);
            tbcConnectionDB.Name = "tbcConnectionDB";
            tbcConnectionDB.SelectedIndex = 0;
            tbcConnectionDB.Size = new Size(470, 200);
            tbcConnectionDB.TabIndex = 3;
            // 
            // tpParameters
            // 
            tpParameters.Controls.Add(nudPort);
            tpParameters.Controls.Add(lblPort);
            tpParameters.Controls.Add(lblDataBase);
            tpParameters.Controls.Add(lblPassword);
            tpParameters.Controls.Add(lblUsername);
            tpParameters.Controls.Add(btConnect);
            tpParameters.Controls.Add(lblHostname);
            tpParameters.Controls.Add(txtDataBase);
            tpParameters.Controls.Add(txtPassword);
            tpParameters.Controls.Add(txtUsername);
            tpParameters.Controls.Add(txtHostname);
            tpParameters.Location = new Point(4, 24);
            tpParameters.Name = "tpParameters";
            tpParameters.Padding = new Padding(3);
            tpParameters.Size = new Size(462, 172);
            tpParameters.TabIndex = 0;
            tpParameters.Text = "Parameters";
            tpParameters.UseVisualStyleBackColor = true;
            // 
            // nudPort
            // 
            nudPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPort.Location = new Point(383, 6);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(73, 23);
            nudPort.TabIndex = 2;
            nudPort.Value = new decimal(new int[] { 3306, 0, 0, 0 });
            nudPort.ValueChanged += AllTextBox_TextChanged;
            // 
            // lblPort
            // 
            lblPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPort.AutoSize = true;
            lblPort.Location = new Point(345, 8);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(32, 15);
            lblPort.TabIndex = 7;
            lblPort.Text = "Port:";
            lblPort.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDataBase
            // 
            lblDataBase.AutoSize = true;
            lblDataBase.Location = new Point(12, 134);
            lblDataBase.Name = "lblDataBase";
            lblDataBase.Size = new Size(61, 15);
            lblDataBase.TabIndex = 7;
            lblDataBase.Text = "Data Base:";
            lblDataBase.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(13, 91);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(10, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // btConnect
            // 
            btConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btConnect.Location = new Point(345, 130);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(111, 23);
            btConnect.TabIndex = 6;
            btConnect.Text = "Connect";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // lblHostname
            // 
            lblHostname.AutoSize = true;
            lblHostname.Location = new Point(8, 9);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new Size(65, 15);
            lblHostname.TabIndex = 7;
            lblHostname.Text = "Hostname:";
            lblHostname.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDataBase
            // 
            txtDataBase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDataBase.Location = new Point(79, 129);
            txtDataBase.Name = "txtDataBase";
            txtDataBase.Size = new Size(260, 23);
            txtDataBase.TabIndex = 5;
            txtDataBase.TextChanged += AllTextBox_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(79, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(377, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += AllTextBox_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(79, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(377, 23);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += AllTextBox_TextChanged;
            // 
            // txtHostname
            // 
            txtHostname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHostname.Location = new Point(79, 6);
            txtHostname.Name = "txtHostname";
            txtHostname.Size = new Size(260, 23);
            txtHostname.TabIndex = 1;
            txtHostname.TextChanged += AllTextBox_TextChanged;
            // 
            // txtConnectionName
            // 
            txtConnectionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConnectionName.Location = new Point(125, 12);
            txtConnectionName.Name = "txtConnectionName";
            txtConnectionName.Size = new Size(355, 23);
            txtConnectionName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Connection Name:";
            lblName.TextAlign = ContentAlignment.TopRight;
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Enabled = false;
            btOk.Location = new Point(402, 251);
            btOk.Name = "btOk";
            btOk.Size = new Size(78, 23);
            btOk.TabIndex = 9;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.Location = new Point(318, 251);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(78, 23);
            btCancel.TabIndex = 8;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSave.Location = new Point(18, 251);
            btSave.Name = "btSave";
            btSave.Size = new Size(78, 23);
            btSave.TabIndex = 7;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // formConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 286);
            Controls.Add(tbcConnectionDB);
            Controls.Add(txtConnectionName);
            Controls.Add(lblName);
            Controls.Add(btOk);
            Controls.Add(btSave);
            Controls.Add(btCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD Constructor";
            tbcConnectionDB.ResumeLayout(false);
            tpParameters.ResumeLayout(false);
            tpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbcConnectionDB;
        private TabPage tpParameters;
        private Label lblHostname;
        private TextBox txtHostname;
        private TextBox txtConnectionName;
        private Label lblName;
        private Button btOk;
        private Button btConnect;
        private Button btCancel;
        private NumericUpDown nudPort;
        private Label lblPort;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblDataBase;
        private TextBox txtDataBase;
        private Button btSave;
    }
}