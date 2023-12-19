using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.Model
{
    public class DataBaseTable
    {
        public DataBaseTable()
        {
            //PARAMETROS
        }

        public DataBaseTable(string nome)
        {
            var item = new DataBaseTable();
            //item.nome = nome;

        }
        public string Field { get; set; }

        private string _typeFormat;

        public string DbType
        {
            get { return _typeFormat; }
            set { _typeFormat = value?.ToUpper(); }
        }

        public Type codeType { get; set; }

        public bool Nullable { get; set; }

        public string Key { get; set; }

        public string DefaultValue { get; set; }

        public string ExtraArguments { get; set; }

        public override string ToString()
        {
            string text = $"{Field} || {DbType.ToUpper()} {ExtraArguments.ToUpper()}";
            return text;
        }

        public void getCodeType()
        {
            switch (DbType)
            {
                case string s when s.Contains("VARCHAR"):
                    codeType = typeof(string);
                    break;

                case string s when s.Contains("INT"):
                    codeType = typeof(int);
                    break;

                case string s when s.Contains("DOUBLE"):
                    codeType = typeof(double);
                    break;

                case string s when s.Contains("DECIMAL"):
                    codeType = typeof(decimal);
                    break;

                case string s when s.Contains("BOOLEAN"):
                    codeType = typeof(bool);
                    break;

                case string s when s.Contains("DATE"):
                    codeType = typeof(DateTime);
                    break;

                case string s when s.Contains("BLOB"):
                    codeType = typeof(byte[]);
                    break;

                default:
                    codeType = typeof(string);
                    break;
            }
        }

        public string getAliasStringType()
        {
            var dic = new Dictionary<Type, string>();
            dic.Add(typeof(string), "string");
            dic.Add(typeof(int), "int");
            dic.Add(typeof(double), "double");
            dic.Add(typeof(decimal), "decimal");
            dic.Add(typeof(bool), "bool");
            dic.Add(typeof(DateTime), Nullable ? "DateTime?" : "DateTime");
            dic.Add(typeof(byte[]), "byte[]");
            return dic[codeType] == null ? "string" : dic[codeType];

            //VALIDAR NULL + DEFAULT VALUE != null
        }

    }
}
