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
            btGenerate = new Button();
            txtProjectPath = new TextBox();
            btFindProject = new Button();
            gbPasta = new GroupBox();
            label1 = new Label();
            ckNoUseProject = new CheckBox();
            txtModelPath = new TextBox();
            button1 = new Button();
            lblModelFolder = new Label();
            txtDaoPath = new TextBox();
            button2 = new Button();
            lblDataAccessObject = new Label();
            txtControllerPath = new TextBox();
            button3 = new Button();
            lblController = new Label();
            gbDAO = new GroupBox();
            gbContrller = new GroupBox();
            ckNoUseModel = new CheckBox();
            ckNoUseDao = new CheckBox();
            ckNoUseController = new CheckBox();
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
            // btGenerate
            // 
            btGenerate.Location = new Point(12, 517);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(622, 32);
            btGenerate.TabIndex = 1;
            btGenerate.Text = "Create";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Project";
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
            // txtModelPath
            // 
            txtModelPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModelPath.Location = new Point(6, 107);
            txtModelPath.Name = "txtModelPath";
            txtModelPath.Size = new Size(586, 23);
            txtModelPath.TabIndex = 2;
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
            button1.Click += btFind_Click;
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
            // txtDaoPath
            // 
            txtDaoPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDaoPath.Location = new Point(6, 169);
            txtDaoPath.Name = "txtDaoPath";
            txtDaoPath.Size = new Size(586, 23);
            txtDaoPath.TabIndex = 2;
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
            button2.Click += btFind_Click;
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
            // txtControllerPath
            // 
            txtControllerPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtControllerPath.Location = new Point(6, 237);
            txtControllerPath.Name = "txtControllerPath";
            txtControllerPath.Size = new Size(586, 23);
            txtControllerPath.TabIndex = 2;
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
            button3.Click += btFind_Click;
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
            // formConfigMVC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 561);
            Controls.Add(btGenerate);
            Controls.Add(gbPasta);
            Controls.Add(gbContrller);
            Controls.Add(gbDAO);
            Controls.Add(gbModel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConfigMVC";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configure MVC";
            gbPasta.ResumeLayout(false);
            gbPasta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModel;
        private Button btGenerate;
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
    }
}