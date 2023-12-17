using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.Controller
{
    public class Connection
    {
        private MySqlConnection conn;
        private DataAccessObject.Connection data;

        public Connection(MySqlConnection conn)
        {
            this.conn = conn;
            data = new DataAccessObject.Connection(this.conn);
        }

        public List<string> getListTables() => data.getTablesList();

        public List<Model.DataBaseTable> getColumnsList(string table) => data.getColumnsList(table);
    }
}
