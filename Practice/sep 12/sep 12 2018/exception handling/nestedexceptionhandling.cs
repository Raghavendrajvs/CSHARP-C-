using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_12_2018
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
    public class Manager1 : Employee1
    {
        public string HOD;
        public int stock;
        public  float Displaysalary()
        {
            return (stock * 1000) + Salary;
        }

    }
    public class Staff1 : Employee1
    {
        public string Department;
        public  float Displaysalary()
        {
            return Salary ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
               
            try
            {
                Program p = new Program();
                p.DisplayRaghu();
                Manager1 m1 = new Manager1();
                m1.stock = 50;
                m1.Salary = 50000;
                Console.WriteLine("the total pay of manager is" + m1.Displaysalary());

                Staff1 sf1 = new Staff1();
                sf1.Salary = 30000;
                Console.WriteLine("the salary of staff is" + sf1.Displaysalary());

            }
            catch (Exception e1)
            {
                Console.WriteLine("something went wrong");
                Writetolog.Write(e1);

            }
            
               
            
           
            
            Console.ReadLine();

        }

        public void DisplayRaghu()
        {
            try
            {
                Salesman1 sm1=null;//= new Salesman1();

                sm1.Name = "raghu";
                sm1.Salary = 25000;
                Console.WriteLine(sm1.Displaysalary() + " " + sm1.Name);
            }
            catch (Exception e1)
            {
                Console.WriteLine("create an object of salesman not possible");
                //Writetolog.Write(e1);
                throw e1;
            }

            }
    }
}
