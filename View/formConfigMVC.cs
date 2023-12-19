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

            var sbUsing = new StringBuilder();
            var sbBodyCode = new StringBuilder();
            var sbClass = new StringBuilder();

            sbUsing.Append("" +
                "using System;\n" +
                "using System.Collections.Generic;\n" +
                "using System.Linq;\n" +
                "using System.Text;\n" +
                "using System.Threading.Tasks;\n");
            sbUsing.Append("\n");

            foreach (DataBaseTable item in _listItensDataBase)
            {
                sbClass.Append($"        public {item.getAliasStringType()} {item.Field}" + " { get; set; }\n\n");
            }

            sbBodyCode.Append("" +
                $"namespace {nameSpace}\n" +
                "{\n" +
                "    public class DataBaseTable\n" +
                "    {\n" +
                $"{sbClass}" +
                "    }\n" +
                "}");

            string completePath = string.Concat(txtFolderPath.Text, "\\Model.cs");

            var fs = File.Create(completePath);

            fs.Close();

            using(var writer  = new StreamWriter(completePath))
            {
                writer.Write(string.Concat(sbUsing, sbBodyCode));
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
