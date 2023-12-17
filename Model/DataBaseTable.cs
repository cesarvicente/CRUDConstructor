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

        public string Type { get; set; }

        public bool Nullable { get; set; }

        public string Key { get; set; }

        public string DefaultValue { get; set; }

        public string ExtraArguments { get; set; }

    }
}
