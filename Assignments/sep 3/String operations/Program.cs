using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "raghavendra";
            string str2 = "Jinkala";
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine(string.Copy(str1));
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Equals(str1, str2));
            Console.WriteLine(string.Format("Hello {0} {1}", str1, str2));
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.Join(",", str1, str2));
            Console.WriteLine(str1.EndsWith("a"));
            Boolean v = str1.Equals(str2);
            Console.WriteLine(v);
            Console.WriteLine( str1.Clone() );
            char[] d = new char[15];
            str1.CopyTo(3, d, 0, 5);
            Console.WriteLine(d);

            Console.WriteLine(str1.IndexOf("a", 6));
            int y =  str1.Length;
            Console.WriteLine(y);
            string str7 = str1.PadLeft(22);
            Console.WriteLine(str7);
            Console.WriteLine(str1.PadRight(5) + " shri ");
            Console.WriteLine(str1.Skip('r'));
            string [] g = str1.Split('a');
            foreach(string h in g)
            {
                Console.Write(h+" ");
            }
            Console.WriteLine();
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str1.ToUpper());
            string str4 = "  dinesh  ";
            Console.WriteLine(str4.Trim());

            
            
            Console.Read();
        
        }
    }
}
