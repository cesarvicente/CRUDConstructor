namespace CRUDConstructor.View
{
    partial class formConstructor
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
            cbTable = new ComboBox();
            lblTable = new Label();
            btLoadData = new Button();
            gbColumns = new GroupBox();
            lbColumns = new ListBox();
            cklbListColumns = new CheckedListBox();
            gbColumns.SuspendLayout();
            SuspendLayout();
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Location = new Point(12, 27);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(234, 23);
            cbTable.TabIndex = 0;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Location = new Point(12, 9);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(34, 15);
            lblTable.TabIndex = 1;
            lblTable.Text = "Table";
            // 
            // btLoadData
            // 
            btLoadData.Location = new Point(12, 56);
            btLoadData.Name = "btLoadData";
            btLoadData.Size = new Size(234, 23);
            btLoadData.TabIndex = 3;
            btLoadData.Text = "Load Columns";
            btLoadData.UseVisualStyleBackColor = true;
            btLoadData.Click += btLoadData_Click;
            // 
            // gbColumns
            // 
            gbColumns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbColumns.Controls.Add(lbColumns);
            gbColumns.Controls.Add(cklbListColumns);
            gbColumns.Location = new Point(12, 108);
            gbColumns.Name = "gbColumns";
            gbColumns.Size = new Size(788, 327);
            gbColumns.TabIndex = 6;
            gbColumns.TabStop = false;
            gbColumns.Text = "Data Source";
            // 
            // lbColumns
            // 
            lbColumns.FormattingEnabled = true;
            lbColumns.ItemHeight = 15;
            lbColumns.Location = new Point(6, 22);
            lbColumns.Name = "lbColumns";
            lbColumns.Size = new Size(385, 289);
            lbColumns.TabIndex = 7;
            lbColumns.SelectedValueChanged += lbColumns_SelectedValueChanged;
            // 
            // cklbListColumns
            // 
            cklbListColumns.FormattingEnabled = true;
            cklbListColumns.Location = new Point(397, 22);
            cklbListColumns.Name = "cklbListColumns";
            cklbListColumns.Size = new Size(385, 292);
            cklbListColumns.TabIndex = 2;
            // 
            // formConstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 617);
            Controls.Add(gbColumns);
            Controls.Add(btLoadData);
            Controls.Add(lblTable);
            Controls.Add(cbTable);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConstructor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            gbColumns.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTable;
        private Label lblTable;
        private Button btLoadData;
        private GroupBox gbColumns;
        private CheckedListBox cklbListColumns;
        private ListBox lbColumns;
    }
}