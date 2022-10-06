using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
    public class Departmentscs
    {
        public int  Id{ get; set; }
        public string Name{ get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{Id}  \n {Name} \n {Location}";
        }
    }
}
