using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu_assignments
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value to be converted");
            string input= Console.ReadLine();
            Console.WriteLine("select one 1.int 2.float 3.double 4.char 5.string ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        float n = 0;
                        bool done = float.TryParse(input, out n);
                        if (done == true)
                            Console.WriteLine("converted to integer" + (int)n);
                        else
                            Console.WriteLine("not converted to integer");
                    }
                    break;

                case "2":
                    {
                        float n = 0;
                        bool done = float.TryParse(input, out n);
                        if (done == true)
                            Console.WriteLine("converted to float" + n);
                        else
                            Console.WriteLine("not converted to float");
                    }
                    break;
                case "3":
                    {
                        float n = 0;
                        bool done = float.TryParse(input, out n);
                        if (done == true)
                            Console.WriteLine("converted to double" + n);
                        else
                            Console.WriteLine("not converted to double");
                    }
                    break;
                case "4":
                    {
                        float n = 0;
                        bool done = float.TryParse(input, out n);
                        if (done == true)
                            Console.WriteLine("converted to char" + n);
                        else
                            Console.WriteLine("not converted to char");
                    }
                    break;
                case "5":
                    {
                        float n = 0;
                        bool done = float.TryParse(input, out n);
                        if (done == true)
                            Console.WriteLine("converted to string" + n);
                        else
                            Console.WriteLine("not converted to string");
                    }
                    break;

            }

            Console.WriteLine("if you want to continue 1.yes ");
            switch (Console.ReadLine())
            {
                case "1":
                    Main(args);
                    break;

                default:
                    return;
            }
            Console.ReadKey();

        }
    }

}
