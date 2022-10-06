using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace construtor
{
    public class Students
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public float Per { get; set; }
        public int Total { get; set; }
        public void Caluculate()
        {
            Total = Mark1 + Mark2 + Mark3;
            Per = (float)Total / 3;
        }
        override public string ToString()
        {
            return $"rollno   {Rollno}\nname   {Name}\ntoatl   {Total}\npercentage    {Per}";
        }

    }
}
