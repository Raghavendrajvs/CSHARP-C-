using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    public class Employee1
    {
        public int Id;
        public string Name;
        public float Salary;

    }
    public class Salesman1 : Employee1
    {
        public string Workingcity;
        public float Commission;


        public float Displaysalary()
        {
            Console.WriteLine("name of the employee" + Name);
            Console.WriteLine("the name is ");
            return Salary + Commission;
        }
    }
    class Program
    {
       static void Main(string[] args)
       {
            try
            {
               Salesman1 sm1 = null;//= new Salesman1();
               sm1.Name = "raghu";
               sm1.Salary = 25000;
               Console.WriteLine(sm1.Displaysalary() + " " + sm1.Name);

            }
            catch (Exception e1)
            {
               Console.WriteLine("create an object of salesman ");
              //Writetolog.Write(e1);
                    
            }
            Console.ReadKey();
       }
    }
}