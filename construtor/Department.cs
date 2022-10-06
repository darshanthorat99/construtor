using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
    public class Department
    {
        private int did;
        private string dname,location;
  
        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
}
