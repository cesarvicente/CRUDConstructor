using CRUDConstructor.Model;
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
    public partial class formConfigMVC : Form
    {
        private List<DataBaseTable> _listItensDataBase;
        public formConfigMVC(List<DataBaseTable> listItensDataBase)
        {
            _listItensDataBase = listItensDataBase;
            InitializeComponent();
        }

        private void selectPathDestination()
        {
            var browseFolder = new FolderBrowserDialog();

            browseFolder.Description = "Selecione Pasta de Destino";

            browseFolder.ShowDialog();

            txtFolderPath.Text = browseFolder.SelectedPath;
        }

        private void createModelArchive()
        {
            string nameSpace = "CRUDConstructor.Model";

            StringBuilder sb = new StringBuilder();

            sb.Append("" +
                "using System;\n" +
                "using System.Collections.Generic;\n" +
                "using System.Linq;\n" +
                "using System.Text;\n" +
                "using System.Threading.Tasks;\n" +
                "\n" +
                $"namespace {nameSpace}\n" +
                "{\n" +
                "    public class DataBaseTable\n" +
                "    {\n" +
                "        public string Field { get; set; }\n\n" +
                "        public bool Nullable { get; set; }\n\n" +
                "        public string Key { get; set; }\n\n" +
                "    }\n" +
                "}");

            string completePath = string.Concat(txtFolderPath.Text, "\\Model.cs");

            var fs = File.Create(completePath);

            fs.Close();

            using(var writer  = new StreamWriter(completePath))
            {
                writer.Write(sb);
            }

            MessageBox.Show("Save successfully!");
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            selectPathDestination();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text == string.Empty) selectPathDestination();
            createModelArchive();
        }
    }
}
