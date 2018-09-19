using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu1
{
    class raghu1
    {
        static void Main(string[] args)
        {
            //   arithmetic operators
            int n1 = 50, n2 = 10, n3, n4, n5, n6, n7;
            n3 = n1 + n2;
            n4 = n1 - n2;
            n5 = n1 * n2;
            n6 = n1 % n2;
            n7 = n1 / n2;
            Console.WriteLine("add of n1 and n2 is"+ n3);
            Console.WriteLine("sub of n1 and n2 is" + n4);
            Console.WriteLine("mul of n1 and n2 is" + n5);
            Console.WriteLine("div of n1 and n2 is" + n6);
            Console.WriteLine("rem of n1 and n2 is" + n7);

            // increment / decrement operators
            int n8 = ++n5;
            Console.WriteLine(n8);
            Console.WriteLine(++n2+n4++);
            Console.WriteLine(++n7- --n2);

            //  comparision operators
            if(n1==n2)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            if(n1<=n6)
                Console.WriteLine("n1 is less than n8");
            else if(n1!=n2)
                Console.WriteLine("n1 not equal to n2");

            //   logical operators
            if(n8>n1&&n2>n7)
                Console.WriteLine("n8 and n7 are large");
            if(n4<n6||n5>n3)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.Read();
        }
    }
}
