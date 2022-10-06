using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date();
            //Console.WriteLine(d1);
            //Date d2 = new Date(5, 2011, "may");
            //Console.WriteLine(d2);

            //Console.WriteLine("enter emp detail");
            //int id = Convert.ToInt32(Console.ReadLine());
            //int salary = Convert.ToInt32(Console.ReadLine());
            //string name = Console.ReadLine();
            //Emp e1 = new Emp(id, salary, name);
            //Console.WriteLine(e1);



            //Student s1 = new Student(1, 45, 56, 65, "adesh");
            //s1.Caluculate();
            //Console.WriteLine(s1);


            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "c#";
            c1.Fee = 100000;
            Console.WriteLine($"{c1.Id}  {c1.Name}  {c1.Fee}");

            Course c2 = new Course { Id = 2, Name = "c++", Fee = 2000000 };
            Console.WriteLine($"{c2.Id}  {c2.Name}  {c2.Fee} \n\n\n");



            //Department d1=new Department();
            //d1.Did = 2;
            //d1.Dname = "sales";
            //d1.Location = "pune";
            //Console.WriteLine($"{d1.Did}  {d1.Dname}  {d1.Location}");

            //Department d2=new Department { Did= 10,Dname="markting",Location="mumbai"};
            //Console.WriteLine($"{d2.Did}  {d2.Dname}  {d2.Location}\n\n\n");



            Departmentscs D1 = new Departmentscs();
            D1.Id = 1000;
            D1.Name = "It";
            D1.Location = "pune";
            Console.WriteLine($"{D1.Id}  {D1.Name}  {D1.Location}");

            Departmentscs D2 = new Departmentscs { Id = 123, Name = "Govt", Location = "mumbai" };
            Console.WriteLine($"{D2.Id}  {D2.Name}  {D2.Location}\n\n\n");




            Students S1=new Students();
            S1.Rollno = 1;
            S1.Mark1 = 45;
            S1.Mark2 = 50;
            S1.Mark3 = 56;
            S1.Name = "darshan";
            S1.Caluculate();
            Console.WriteLine($"{S1.Rollno} {S1.Total}    {S1.Per}\n\n\n\n ");


            Emp e1=new Emp();
            e1.Id = 1;
            e1.Name = "rahul";
            e1.Basic = 25000;
            e1.Calulations();
            Console.WriteLine($"PF   {e1.Pf}");
            Console.WriteLine($"emp id    {e1.Id}\nemp name     {e1.Name}\nbasic salary    {e1.Basic}\nHRA   {e1.Hra}\n DA  {e1.Da}\ngross salary {e1.Gross}\n net salay{e1.Net}");

            Emp e2=new Emp();
            Console.WriteLine("enter the id name basic salary");
            e2.Id = Convert.ToInt32(Console.ReadLine());
            e2.Name = Console.ReadLine();
            e2.Basic=Convert.ToInt32(Console.ReadLine());
            e2.Calulations();
            Console.WriteLine($"Pf  {e2.Pf}");
            Console.WriteLine($"emp id    {e2.Id}\nemp name     {e2.Name}\nbasic salary    {e2.Basic}\nHRA   {e2.Hra}\n DA  {e2.Da}\ngross salary {e2.Gross}\n net salay{e2.Net}");

        }
    }  
}
    