using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu_assignments
{
    class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the operator");
            string x = Console.ReadLine();
            Console.WriteLine(" " + x);
            switch (x)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    Console.WriteLine("arithmetic operators");
                    break;
                case ">":
                case "<":
                case "<=":
                case ">=":
                case "==":
                case "!=":
                    Console.WriteLine("relational operators");
                    break;
                case "++":
                case "--":
                    Console.WriteLine("increment or decrement operators");
                    break;
                case "&&":
                case "||":
                    Console.WriteLine("logical operators");
                    break;
                case "?":
                case ":":
                    Console.WriteLine("conditional operators");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
            Console.Read();
        }
    }
}