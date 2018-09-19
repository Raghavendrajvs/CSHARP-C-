using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu_assignments
{
    class Class3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" " + y);
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
                Console.WriteLine("its a leap year" + y);
            else
                Console.WriteLine("its not a leap year" + y);
            Console.Read();
        }
    }
}
