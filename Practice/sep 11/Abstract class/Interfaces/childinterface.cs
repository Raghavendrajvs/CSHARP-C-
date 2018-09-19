using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace childinterface
{
    public interface ISalesman
    {
        void getreport();
    }
    public abstract class Employee
    {
        public int Id;
        public string Name;
        public float Salary;
        public abstract float Displaysalary();
       
    }
    public class Salesman : Employee, ISalesman
    {
        public string Workingcity;
        public float Commission;
        public override float Displaysalary()
        {
            return Salary + Commission;
        }
        public void getreport()
        {
            Console.WriteLine("the report is good");
        }
    }
    public class Manager : Employee
    {
        public string HOD;
        public int stock;
        public override float Displaysalary()
        {
            return (stock * 1000) + Salary;
        }
    }
    public class Staff : Employee
    {
        public string Department;
        public override float Displaysalary()
        {
            return Salary;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Salesman sm1 = new Salesman();
            sm1.Commission = 500f;
            sm1.Id = 23;
            sm1.Name = "srinu";
            sm1.Salary = 25000;
            sm1.getreport();
            Console.WriteLine("the name of salesman is\t" + sm1.Name + "\twith id\t" + sm1.Id + "and total pay is" + sm1.Displaysalary());

            Manager m1 = new Manager();
            m1.stock = 50;
            m1.Salary = 50000;
            Console.WriteLine("the total pay of manager is" + m1.Displaysalary());

            Staff sf1 = new Staff();
            sf1.Salary = 30000;
            Console.WriteLine("the salary of staff is" + sf1.Displaysalary());

            Console.ReadLine();
         
        }
    }

}
