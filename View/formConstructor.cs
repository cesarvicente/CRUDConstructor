using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private List<string> loadColumns(string _column)
        {
            var columns = _controllerConnection.getColumnsList(_column);

            var stringColumnList = new List<string>();

            foreach (Model.DataBaseTable column in columns)
            {
                stringColumnList.Add(column.Field);
            }

            return stringColumnList;
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            loadColumns();
        }

        private void loadColumns()
        {
            cklbListColumns.DataSource = loadColumns(lbColumns.SelectedItems[0].ToString());
        }

        private void lbColumns_SelectedValueChanged(object sender, EventArgs e)
        {
            loadColumns();
        }
    }
}
