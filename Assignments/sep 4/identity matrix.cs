using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raghu_assignments
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[x,x];
            
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                        if (i == j)
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 0;
                        }

                }
            
            
                for (int m = 0; m < x; m++)
                {
                for (int n = 0; n < x; n++)
                {
                    Console.Write(a[m, n] + " ");
                }
                Console.WriteLine();
            }
              
            Console.ReadLine();

        }
    }

}
