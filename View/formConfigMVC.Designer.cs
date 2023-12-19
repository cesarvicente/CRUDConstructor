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
            txtFolderPath = new TextBox();
            btFind = new Button();
            SuspendLayout();
            // 
            // gbModel
            // 
            gbModel.Location = new Point(12, 41);
            gbModel.Name = "gbModel";
            gbModel.Size = new Size(230, 336);
            gbModel.TabIndex = 0;
            gbModel.TabStop = false;
            gbModel.Text = "Model";
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(12, 383);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(230, 55);
            btGenerate.TabIndex = 1;
            btGenerate.Text = "Create";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(12, 12);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(548, 23);
            txtFolderPath.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.BackgroundImage = Properties.Resources._3767084;
            btFind.BackgroundImageLayout = ImageLayout.Zoom;
            btFind.Location = new Point(559, 13);
            btFind.Name = "btFind";
            btFind.Size = new Size(25, 23);
            btFind.TabIndex = 3;
            btFind.TextAlign = ContentAlignment.BottomRight;
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // formConfigMVC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btFind);
            Controls.Add(txtFolderPath);
            Controls.Add(btGenerate);
            Controls.Add(gbModel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConfigMVC";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configure MVC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbModel;
        private Button btGenerate;
        private TextBox txtFolderPath;
        private Button btFind;
    }
}