using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.DataAccessObject
{
    internal class Connection
    {
        private MySqlConnection conn;
        public Connection(MySqlConnection _conn)
        {
            conn = _conn;
        }

        internal List<string> getTablesList()
        {
            var listTables = new List<string>();

            using(MySqlConnection conn = this.conn)
            {
                using(var command = new MySqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SHOW TABLES";

                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            listTables.Add(reader.GetString(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    return listTables;
                }
            }
        }

    }
}
