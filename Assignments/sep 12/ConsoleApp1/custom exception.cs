using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmployeeException : ApplicationException
    {
        //public string Message;
        public EmployeeException(string Message) : base(Message)
        {
          //  this.Message = Message;
        }
    }
    public class Employee
    {
        public int Id;
        public string Name;
        public float Salary;
       
       public void Bonus(float Bonusamount)
        {
            if(Salary==0)
            {
                throw new EmployeeException("\tsalary not credited" );
            }
            else
            {
                Salary = Salary;
            }
            if(10%(Salary)<Bonusamount)
            {
                throw new EmployeeException("\tbonusamount is not credited");
            }
            else
            {
                Salary = Salary + Bonusamount;
            }
        }
    }
    public class Salesman : Employee
    {
        public string Workingcity;
        public float Commission;
        public float Displaysalary()
        {
            return Salary + Commission;
        }
    }
   
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Salesman sm1= new Salesman();
                sm1.Commission = 500f;
                sm1.Id = 23;
                sm1.Name = "srinu";
                sm1.Salary = 0;
                Console.WriteLine("the name of salesman is\t" + sm1.Name + "\twith id\t" + sm1.Id + "and total pay is" + sm1.Displaysalary());
                sm1.Bonus(400);
            }
            catch (ApplicationException e1)
            {
                Console.WriteLine("error occured" + e1.Message);
            }

            catch (Exception e1)
            {
                Console.WriteLine("error occured" + e1.Message);
            }

            Console.ReadLine();

        }
    }
}
