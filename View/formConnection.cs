using CRUDConstructor.Model;
using CRUDConstructor.View;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;

namespace CRUDConstructor
{
    public partial class formConnection : Form
    {
        private string _filePath;
        public formConnection()
        {
            InitializeComponent();
            _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CRUDConstructor\\DataConnection.json");
            LoadDataBaseConnection();
        }

        private void SaveDataBaseConnection()
        {
            var connection = GetDataBaseConnection();

            if (!File.Exists(_filePath))
            {
                FileStream fs = File.Create(_filePath);
                fs.Close();
            }

            using (var writer = new StreamWriter(_filePath))
            {
                writer.Write(connection.GetJson());
            }

            MessageBox.Show("Save successfully!");
        }

        private void LoadDataBaseConnection()
        {
            if (!File.Exists(_filePath)) return;

            var connection = new DataBaseConnection();

            using (var reader = new StreamReader(_filePath))
            {
                string jsonRead = reader.ReadToEnd();
                connection = JsonConvert.DeserializeObject<DataBaseConnection>(jsonRead);
            }

            SetDataBaseConnection(connection);
        }

        private DataBaseConnection GetDataBaseConnection()
        {
            return new DataBaseConnection()
            {
                name = txtConnectionName.Text,
                hostname = txtHostname.Text,
                port = Convert.ToInt32(nudPort.Value),
                username = txtUsername.Text,
                password = txtPassword.Text,
                dataBase = txtDataBase.Text,
            };
        }

        private void SetDataBaseConnection(DataBaseConnection connection)
        {
            txtConnectionName.Text = connection.name;
            txtHostname.Text = connection.hostname;
            nudPort.Value = connection.port;
            txtUsername.Text = connection.username;
            txtPassword.Text = connection.password;
            txtDataBase.Text = connection.dataBase;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveDataBaseConnection();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            var connection = GetDataBaseConnection();
            (bool, string) testReturn = connection.TestMysqlConnection();

            btOk.Enabled = testReturn.Item1;
            MessageBox.Show(testReturn.Item2);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Hide();
            new formConstructor(GetDataBaseConnection().GetMysqlConnection()).ShowDialog();
            Close();
        }

        private void AllTextBox_TextChanged(object sender, EventArgs e)
        {
            btOk.Enabled = false;
        }
    }
}