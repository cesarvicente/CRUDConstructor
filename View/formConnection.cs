using CRUDConstructor.Model;

namespace CRUDConstructor
{
    public partial class formConnection : Form
    {
        public formConnection()
        {
            InitializeComponent();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            var connection = new DataBaseConnection()
            {
                hostname = "localhost",
                dataBase = "testeDB",
                port = 3306,
                username = "userTest",
                password = "passTest"
            };

            Console.WriteLine(connection.getStringConnection());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}