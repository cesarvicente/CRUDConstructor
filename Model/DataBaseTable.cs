using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.Model
{
    public class DataBaseTable
    {
        public string Field { get; set; }

        private string _typeFormat;

        public string Type 
        {
            get { return _typeFormat; } 
            set {  _typeFormat = value?.ToUpper(); } 
        }

        public codeType codeType { get; set; }

        public bool Nullable { get; set; }

        public string Key { get; set; }

        public string DefaultValue { get; set; }

        public string ExtraArguments { get; set; }

        public override string ToString()
        {
            string text = $"{Field} || {Type.ToUpper()} {ExtraArguments.ToUpper()}";
            return text;
        }
        
        public void getTypeFromDataBase()
        {
            switch (Type)
            {
                case string s when s.Contains("VARCHAR"):
                    codeType =  new codeType("string");
                    break;

                case string s when s.Contains("INT"):
                    codeType = new codeType("int");
                    break;

                case string s when s.Contains("DECIMAL"):
                    codeType = new codeType("decimal");
                    break;

                case string s when s.Contains("DOUBLE"):
                    codeType = new codeType("double");
                    break;

                default:
                    codeType = new codeType("string");
                    break;
            }
        }
    }
}
