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

        public Connection(MySqlConnection _conn)
        {
            conn = _conn;
            data = new DataAccessObject.Connection(conn);
        }

        public List<string> getListTables() => data.getTablesList();
    }
}
