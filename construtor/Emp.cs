using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Basic { get; set; }
        public float Gross { get; set; }
        public float Net { get; set; }
        public float Hra { get; set; }
        public float Da { get; set; }
        public float Pf { get; set; }

        public void Calulations()
        {
            if (Basic < 10000)
            {
                Net = Basic - 200f;
            }
     
      else if (Basic >= 10000 && Basic < 20000)
            {
                Hra = Basic * 0.4f;
                Da = Basic * 0.2f;
                Pf = Basic * 0.12f;
                Gross = Basic + Hra + Da;
                Net = Gross - Pf;
            }
     else if (Basic >= 20000 && Basic <= 30000)
            {
                Hra = Basic * 0.45f;
                Da = Basic * 0.25f;
                Pf = Basic * 0.12f;
                Gross = Basic + Hra + Da;
                Net = Gross - Pf;
            }












        }

                    
    }

        
    
}
