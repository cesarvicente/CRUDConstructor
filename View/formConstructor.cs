using CRUDConstructor.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDConstructor.View
{
    public partial class formConstructor : Form
    {
        private static MySqlConnection _conn;

        private static Controller.Connection _controllerConnection;

        public formConstructor(MySqlConnection conn)
        {
            _conn = conn;
            _controllerConnection = new Controller.Connection(conn);

            InitializeComponent();
            loadTableList_cbTable();


        }

        private void loadTableList_cbTable()
        {
            var listTables = _controllerConnection.getListTables();

            cbTable.DataSource = listTables;
            lbColumns.DataSource = listTables;

        }

        private void loadCBTypes()
        {
            var listTypes = new codeType("").GetDefaultList();

            var cbTypeColumn = (DataGridViewComboBoxColumn)dgvColumns.Columns["cbTypeColumn"];
            cbTypeColumn.DataSource = listTypes;
            cbTypeColumn.DisplayMember = "name";
            cbTypeColumn.ValueMember = "type";
        }

        private void loadColumnList(DataGridView _dataGrid)
        {
            var columns = _controllerConnection.getColumnsList(lbColumns.SelectedItem);

            _dataGrid.DataSource = columns;
        }

        private void lbColumns_SelectedValueChanged(object sender, EventArgs e)
        {
            loadColumnList(dgvColumns);
            loadCBTypes();
        }

    }
}
