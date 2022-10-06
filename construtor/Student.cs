using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
        public class Student
        {
            private int rollno, mark1, mark2, mark3;
    private string name;
    private float per;
    private int total;
    public Student(int rollno, int mark1, int mark2, int mark3,string name)
    {
        this.rollno = rollno;
        this.name = name;
        this.mark1 = mark1;
        this.mark2 = mark2;
        this.mark2 = mark2;
    }
    public void Caluculate()
    {
        total = mark1 + mark2 + mark3;
            per = (float)total / 3;

    }
        override public string ToString()
        {
        return $"rollno   {rollno}\nname   {name}\ntoatl   {total}\npercentage    {per}";

     }
        }
    }
