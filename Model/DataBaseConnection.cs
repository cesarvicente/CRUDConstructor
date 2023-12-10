using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.Model
{
    public class DataBaseConnection
    {
        public string name { get; set; } = string.Empty;

        public string hostname { get; set; } = string.Empty;

        public string dataBase { get; set; } = string.Empty;

        public int port { get; set; } = 3306;

        public string username { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string sslMode { get; set; } = "none";

        public string getStringConnection() => $"datasource={hostname};database={dataBase};port={port};userId={username};password={password};SslMode={sslMode};AllowPublicKeyRetrieval=True";

        public MySqlConnection getMysqlConnection()
        {
            var conn = new MySqlConnection(getStringConnection());
            return conn;

        }

        public (bool, string) testMysqlConnection()
        {
            var coon = getMysqlConnection();

            try
            {
                coon.Open();
                return (true, $"Connection Successfully!\nHost: {hostname}\nPort: {port}\nUser: {username}");
            }
            catch (Exception ex)
            {
                return (true, $"Failed to Connect to MySQL at {hostname}:{port} with user {username}\n{ex.Message}");
            }
        }
    }
}
