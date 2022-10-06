using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
    public class Date
    {
        private int day;
        private int year;
        private string month;


    public Date()
        {
            day = 1;
            year = 2022;
            month = "sept";
        }
        public Date(int day,int year,string month)
        {
          this.day = day;
            this.year = year;   
            this.month = month;
        }
         override public string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
 
}
