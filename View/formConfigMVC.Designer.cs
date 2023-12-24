namespace CRUDConstructor.View
{
    partial class formConfigMVC
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
            gbModel = new GroupBox();
            btCreate = new Button();
            txtProjectPath = new TextBox();
            btFindProject = new Button();
            gbPasta = new GroupBox();
            ckNoUseController = new CheckBox();
            ckNoUseDao = new CheckBox();
            ckNoUseModel = new CheckBox();
            ckNoUseProject = new CheckBox();
            lblController = new Label();
            button3 = new Button();
            lblDataAccessObject = new Label();
            button2 = new Button();
            lblModelFolder = new Label();
            txtControllerPath = new TextBox();
            button1 = new Button();
            txtDaoPath = new TextBox();
            label1 = new Label();
            txtModelPath = new TextBox();
            gbDAO = new GroupBox();
            gbContrller = new GroupBox();
            txtArchiveName = new TextBox();
            lblArchiveName = new Label();
            gbPasta.SuspendLayout();
            SuspendLayout();
            // 
            // gbModel
            // 
            gbModel.Location = new Point(12, 293);
            gbModel.Name = "gbModel";
            gbModel.Size = new Size(203, 218);
            gbModel.TabIndex = 0;
            gbModel.TabStop = false;
            gbModel.Text = "Model";
            // 
            // btCreate
            // 
            btCreate.Enabled = false;
            btCreate.Location = new Point(222, 531);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(411, 25);
            btCreate.TabIndex = 1;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btGenerate_Click;
            // 
            // txtProjectPath
            // 
            txtProjectPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProjectPath.Location = new Point(6, 50);
            txtProjectPath.Name = "txtProjectPath";
            txtProjectPath.Size = new Size(586, 23);
            txtProjectPath.TabIndex = 2;
            // 
            // btFindProject
            // 
            btFindProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFindProject.BackgroundImage = Properties.Resources._3767084;
            btFindProject.BackgroundImageLayout = ImageLayout.Zoom;
            btFindProject.Location = new Point(591, 51);
            btFindProject.Name = "btFindProject";
            btFindProject.Size = new Size(25, 23);
            btFindProject.TabIndex = 3;
            btFindProject.TextAlign = ContentAlignment.BottomRight;
            btFindProject.UseVisualStyleBackColor = true;
            btFindProject.Click += btFind_Click;
            // 
            // gbPasta
            // 
            gbPasta.Controls.Add(ckNoUseController);
            gbPasta.Controls.Add(ckNoUseDao);
            gbPasta.Controls.Add(ckNoUseModel);
            gbPasta.Controls.Add(ckNoUseProject);
            gbPasta.Controls.Add(lblController);
            gbPasta.Controls.Add(button3);
            gbPasta.Controls.Add(lblDataAccessObject);
            gbPasta.Controls.Add(button2);
            gbPasta.Controls.Add(lblModelFolder);
            gbPasta.Controls.Add(txtControllerPath);
            gbPasta.Controls.Add(button1);
            gbPasta.Controls.Add(txtDaoPath);
            gbPasta.Controls.Add(label1);
            gbPasta.Controls.Add(txtModelPath);
            gbPasta.Controls.Add(btFindProject);
            gbPasta.Controls.Add(txtProjectPath);
            gbPasta.Location = new Point(12, 12);
            gbPasta.Name = "gbPasta";
            gbPasta.Size = new Size(622, 275);
            gbPasta.TabIndex = 0;
            gbPasta.TabStop = false;
            gbPasta.Text = "Folders";
            // 
            // ckNoUseController
            // 
            ckNoUseController.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckNoUseController.AutoSize = true;
            ckNoUseController.CheckAlign = ContentAlignment.MiddleRight;
            ckNoUseController.Location = new Point(496, 213);
            ckNoUseController.Name = "ckNoUseController";
            ckNoUseController.Size = new Size(120, 19);
            ckNoUseController.TabIndex = 5;
            ckNoUseController.Text = "No Use Controller";
            ckNoUseController.UseVisualStyleBackColor = true;
            // 
            // ckNoUseDao
            // 
            ckNoUseDao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckNoUseDao.AutoSize = true;
            ckNoUseDao.CheckAlign = ContentAlignment.MiddleRight;
            ckNoUseDao.Location = new Point(454, 145);
            ckNoUseDao.Name = "ckNoUseDao";
            ckNoUseDao.Size = new Size(162, 19);
            ckNoUseDao.TabIndex = 5;
            ckNoUseDao.Text = "No Use DataAccessObject";
            ckNoUseDao.UseVisualStyleBackColor = true;
            // 
            // ckNoUseModel
            // 
            ckNoUseModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckNoUseModel.AutoSize = true;
            ckNoUseModel.CheckAlign = ContentAlignment.MiddleRight;
            ckNoUseModel.Location = new Point(515, 83);
            ckNoUseModel.Name = "ckNoUseModel";
            ckNoUseModel.Size = new Size(101, 19);
            ckNoUseModel.TabIndex = 5;
            ckNoUseModel.Text = "No Use Model";
            ckNoUseModel.UseVisualStyleBackColor = true;
            // 
            // ckNoUseProject
            // 
            ckNoUseProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckNoUseProject.AutoSize = true;
            ckNoUseProject.CheckAlign = ContentAlignment.MiddleRight;
            ckNoUseProject.Location = new Point(512, 26);
            ckNoUseProject.Name = "ckNoUseProject";
            ckNoUseProject.Size = new Size(104, 19);
            ckNoUseProject.TabIndex = 5;
            ckNoUseProject.Text = "No Use Project";
            ckNoUseProject.UseVisualStyleBackColor = true;
            // 
            // lblController
            // 
            lblController.AutoSize = true;
            lblController.Location = new Point(6, 219);
            lblController.Name = "lblController";
            lblController.Size = new Size(60, 15);
            lblController.TabIndex = 4;
            lblController.Text = "Controller";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackgroundImage = Properties.Resources._3767084;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(591, 238);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 3;
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // lblDataAccessObject
            // 
            lblDataAccessObject.AutoSize = true;
            lblDataAccessObject.Location = new Point(6, 151);
            lblDataAccessObject.Name = "lblDataAccessObject";
            lblDataAccessObject.Size = new Size(102, 15);
            lblDataAccessObject.TabIndex = 4;
            lblDataAccessObject.Text = "DataAccessObject";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = Properties.Resources._3767084;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(591, 170);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 3;
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // lblModelFolder
            // 
            lblModelFolder.AutoSize = true;
            lblModelFolder.Location = new Point(6, 89);
            lblModelFolder.Name = "lblModelFolder";
            lblModelFolder.Size = new Size(41, 15);
            lblModelFolder.TabIndex = 4;
            lblModelFolder.Text = "Model";
            // 
            // txtControllerPath
            // 
            txtControllerPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtControllerPath.Location = new Point(6, 237);
            txtControllerPath.Name = "txtControllerPath";
            txtControllerPath.Size = new Size(586, 23);
            txtControllerPath.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources._3767084;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(591, 108);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 3;
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDaoPath
            // 
            txtDaoPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDaoPath.Location = new Point(6, 169);
            txtDaoPath.Name = "txtDaoPath";
            txtDaoPath.Size = new Size(586, 23);
            txtDaoPath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Project";
            // 
            // txtModelPath
            // 
            txtModelPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModelPath.Location = new Point(6, 107);
            txtModelPath.Name = "txtModelPath";
            txtModelPath.Size = new Size(586, 23);
            txtModelPath.TabIndex = 2;
            // 
            // gbDAO
            // 
            gbDAO.Location = new Point(222, 293);
            gbDAO.Name = "gbDAO";
            gbDAO.Size = new Size(203, 218);
            gbDAO.TabIndex = 0;
            gbDAO.TabStop = false;
            gbDAO.Text = "DataAccessObject";
            // 
            // gbContrller
            // 
            gbContrller.Location = new Point(431, 293);
            gbContrller.Name = "gbContrller";
            gbContrller.Size = new Size(203, 218);
            gbContrller.TabIndex = 0;
            gbContrller.TabStop = false;
            gbContrller.Text = "Controller";
            // 
            // txtArchiveName
            // 
            txtArchiveName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtArchiveName.Location = new Point(97, 532);
            txtArchiveName.Name = "txtArchiveName";
            txtArchiveName.Size = new Size(118, 23);
            txtArchiveName.TabIndex = 2;
            txtArchiveName.TextChanged += txtArchiveName_TextChanged;
            // 
            // lblArchiveName
            // 
            lblArchiveName.AutoSize = true;
            lblArchiveName.Location = new Point(12, 535);
            lblArchiveName.Name = "lblArchiveName";
            lblArchiveName.Size = new Size(79, 15);
            lblArchiveName.TabIndex = 4;
            lblArchiveName.Text = "Model Name:";
            // 
            // formConfigMVC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 566);
            Controls.Add(btCreate);
            Controls.Add(gbPasta);
            Controls.Add(gbContrller);
            Controls.Add(gbDAO);
            Controls.Add(gbModel);
            Controls.Add(txtArchiveName);
            Controls.Add(lblArchiveName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConfigMVC";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configure MVC";
            gbPasta.ResumeLayout(false);
            gbPasta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbModel;
        private Button btCreate;
        private TextBox txtProjectPath;
        private Button btFindProject;
        private GroupBox gbPasta;
        private Label label1;
        private CheckBox ckNoUseProject;
        private Label lblModelFolder;
        private Button button1;
        private TextBox txtModelPath;
        private Label lblController;
        private Button button3;
        private Label lblDataAccessObject;
        private Button button2;
        private TextBox txtControllerPath;
        private TextBox txtDaoPath;
        private GroupBox gbDAO;
        private GroupBox gbContrller;
        private CheckBox ckNoUseController;
        private CheckBox ckNoUseDao;
        private CheckBox ckNoUseModel;
        private TextBox txtArchiveName;
        private Label lblArchiveName;
    }
}