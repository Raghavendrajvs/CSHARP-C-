using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Truck
    {
        public int number;
        public int speed;
        public string name;
        public Truck(int number, int speed, string name)
        {
            this.number = number;
            this.speed = speed;
            this.name = name;
        }
        public void raghu()
        {
            Console.WriteLine("number\t" + number + "\tspeed\t" + speed + "\tname\t" + name);

        }
        public static void Main(string[] args)
        {
            //powerex
            power p = new power();
            p.raghu1();

            //truck ex
            Truck t = new Truck(5045, 50, "raghu");
            t.raghu();


            Console.ReadLine();
        }
    }
    public  class power
    {
        public int value;
        public string name;
        public power()
        {
            value = 50;
            name = "star";
        }
        public void raghu1()
        {
            Console.WriteLine("value\t"+value+"\tname\t"+name);
        }
       

    }
}

