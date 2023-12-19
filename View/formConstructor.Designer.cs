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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cbTable = new ComboBox();
            lblTable = new Label();
            gbColumns = new GroupBox();
            dgvColumns = new DataGridView();
            SELECTED = new DataGridViewCheckBoxColumn();
            fieldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DbType = new DataGridViewTextBoxColumn();
            cbTypeColumn = new DataGridViewComboBoxColumn();
            nullableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            keyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extraArgumentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataBaseTableBindingSource = new BindingSource(components);
            lbColumns = new ListBox();
            btNext = new Button();
            gbColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBaseTableBindingSource).BeginInit();
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
            // gbColumns
            // 
            gbColumns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbColumns.Controls.Add(dgvColumns);
            gbColumns.Controls.Add(lbColumns);
            gbColumns.Location = new Point(12, 56);
            gbColumns.Name = "gbColumns";
            gbColumns.Size = new Size(808, 327);
            gbColumns.TabIndex = 6;
            gbColumns.TabStop = false;
            gbColumns.Text = "Data Source";
            // 
            // dgvColumns
            // 
            dgvColumns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvColumns.AutoGenerateColumns = false;
            dgvColumns.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvColumns.ColumnHeadersHeight = 30;
            dgvColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvColumns.Columns.AddRange(new DataGridViewColumn[] { SELECTED, fieldDataGridViewTextBoxColumn, DbType, cbTypeColumn, nullableDataGridViewCheckBoxColumn, keyDataGridViewTextBoxColumn, defaultValueDataGridViewTextBoxColumn, extraArgumentsDataGridViewTextBoxColumn });
            dgvColumns.DataSource = dataBaseTableBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvColumns.DefaultCellStyle = dataGridViewCellStyle2;
            dgvColumns.Location = new Point(190, 22);
            dgvColumns.Name = "dgvColumns";
            dgvColumns.RowHeadersWidth = 10;
            dgvColumns.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvColumns.RowTemplate.Height = 20;
            dgvColumns.Size = new Size(612, 289);
            dgvColumns.TabIndex = 7;
            // 
            // SELECTED
            // 
            SELECTED.DataPropertyName = "Selected";
            SELECTED.HeaderText = "CK";
            SELECTED.Name = "SELECTED";
            SELECTED.Resizable = DataGridViewTriState.False;
            SELECTED.Width = 30;
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            fieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DbType
            // 
            DbType.DataPropertyName = "DbType";
            DbType.HeaderText = "DbType";
            DbType.Name = "DbType";
            DbType.ReadOnly = true;
            // 
            // cbTypeColumn
            // 
            cbTypeColumn.DataPropertyName = "codeType";
            cbTypeColumn.HeaderText = "C# Type";
            cbTypeColumn.Name = "cbTypeColumn";
            // 
            // nullableDataGridViewCheckBoxColumn
            // 
            nullableDataGridViewCheckBoxColumn.DataPropertyName = "Nullable";
            nullableDataGridViewCheckBoxColumn.HeaderText = "Null";
            nullableDataGridViewCheckBoxColumn.Name = "nullableDataGridViewCheckBoxColumn";
            nullableDataGridViewCheckBoxColumn.ReadOnly = true;
            nullableDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.False;
            nullableDataGridViewCheckBoxColumn.Width = 50;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            keyDataGridViewTextBoxColumn.HeaderText = "Key";
            keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            keyDataGridViewTextBoxColumn.ReadOnly = true;
            keyDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            keyDataGridViewTextBoxColumn.Width = 50;
            // 
            // defaultValueDataGridViewTextBoxColumn
            // 
            defaultValueDataGridViewTextBoxColumn.DataPropertyName = "DefaultValue";
            defaultValueDataGridViewTextBoxColumn.HeaderText = "DefaultValue";
            defaultValueDataGridViewTextBoxColumn.Name = "defaultValueDataGridViewTextBoxColumn";
            defaultValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraArgumentsDataGridViewTextBoxColumn
            // 
            extraArgumentsDataGridViewTextBoxColumn.DataPropertyName = "ExtraArguments";
            extraArgumentsDataGridViewTextBoxColumn.HeaderText = "ExtraArguments";
            extraArgumentsDataGridViewTextBoxColumn.Name = "extraArgumentsDataGridViewTextBoxColumn";
            extraArgumentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataBaseTableBindingSource
            // 
            dataBaseTableBindingSource.DataSource = typeof(Model.DataBaseTable);
            // 
            // lbColumns
            // 
            lbColumns.FormattingEnabled = true;
            lbColumns.ItemHeight = 15;
            lbColumns.Location = new Point(6, 22);
            lbColumns.Name = "lbColumns";
            lbColumns.Size = new Size(178, 289);
            lbColumns.TabIndex = 7;
            lbColumns.SelectedValueChanged += lbColumns_SelectedValueChanged;
            // 
            // btNext
            // 
            btNext.Location = new Point(660, 389);
            btNext.Name = "btNext";
            btNext.Size = new Size(160, 41);
            btNext.TabIndex = 7;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // formConstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 442);
            Controls.Add(btNext);
            Controls.Add(gbColumns);
            Controls.Add(lblTable);
            Controls.Add(cbTable);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formConstructor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            gbColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBaseTableBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTable;
        private Label lblTable;
        private GroupBox gbColumns;
        private ListBox lbColumns;
        private DataGridView dgvColumns;
        private BindingSource dataBaseTableBindingSource;
        private DataGridViewCheckBoxColumn SELECTED;
        private DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DbType;
        private DataGridViewComboBoxColumn cbTypeColumn;
        private DataGridViewCheckBoxColumn nullableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn extraArgumentsDataGridViewTextBoxColumn;
        private Button btNext;
    }
}