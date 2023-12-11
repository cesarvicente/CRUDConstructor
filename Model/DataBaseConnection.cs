using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CRUDConstructor.Model
{
    public class DataBaseConnection
    {
        [Key, Display(Name = "name", Description = "name")]
        public string name { get; set; } = string.Empty;

        public string hostname { get; set; } = string.Empty;

        public string dataBase { get; set; } = string.Empty;

        public int port { get; set; } = 3306;

        public string username { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string sslMode { get; set; } = "none";

        public string GetStringConnection() => $"datasource={hostname};database={dataBase};port={port};userId={username};password={password};SslMode={sslMode};AllowPublicKeyRetrieval=True";

        public MySqlConnection GetMysqlConnection()
        {
            var conn = new MySqlConnection(GetStringConnection());
            return conn;

        }

        public (bool, string) TestMysqlConnection()
        {
            var coon = GetMysqlConnection();

            try
            {
                coon.Open();
                return (true, $"Connection Successfully!\nHost: {hostname}\nPort: {port}\nUser: {username}");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to Connect to MySQL at {hostname}:{port} with user {username}\n\n{ex.Message}");
            }
        }

        public string GetJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

    }
}
