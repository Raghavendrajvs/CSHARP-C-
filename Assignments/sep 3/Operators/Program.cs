using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            char y = 'r';
            float z = 1.2f;
            double w = 0.236987;
            string s = "raghu";
            Console.WriteLine("size of int is "+sizeof(int)+" min is"+int.MinValue+" max is"+int.MaxValue);
            Console.WriteLine("size of char is "+sizeof(char)+" min is "+char.MinValue+" max is "+char.MaxValue);
            Console.WriteLine("size of float is " + sizeof(float) + " min is " + float.MinValue + " max is " + float.MaxValue);
            Console.WriteLine("size of double is " + sizeof(double) + " min is " + double.MinValue + " max is " + double.MaxValue);
           //Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(s));

            Console.Read();
        }
    }
}
