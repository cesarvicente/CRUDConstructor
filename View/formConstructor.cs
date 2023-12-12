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
        public formConstructor(MySqlConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }
    }
}
