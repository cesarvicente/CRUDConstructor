using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConstructor.Model
{
    public class codeType
    {
        public codeType(string name = "") { this.name = name; }

        public string name { get; set; }

        public Type type { get {
                switch (name)
                {
                    default: return typeof(string);
                    case "int": return typeof(int);
                    case "double": return typeof(double);
                    case "decimal": return typeof(decimal);
                    case "bool": return typeof(bool);
                    case "DateTime": return typeof(DateTime);
                    case "byte[]": return typeof(byte[]);
                }
            } }

        public List<codeType> GetDefaultList()
        {
            return new List<codeType>
            {
                new codeType("string"),
                new codeType("int"),
                new codeType("double"),
                new codeType("decimal"),
                new codeType("bool"),
                new codeType("DateTime"),
                new codeType("byte[]"),
            };
        }
    }
}
