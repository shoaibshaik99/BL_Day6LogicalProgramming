using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day6LogicalProgramming
{
    internal class FibonacciSeries
    {
        public static void PrintFibonacciSeries()
        {
            Console.Write("How many terms of Fibonacci Series do you want to print: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 1;
            int num;
            if (n == 1)
                Console.WriteLine(0);
            else if (n == 2)
                Console.WriteLine("0 1");
            else if (n > 2)
            {
                Console.Write("0 1 ");
                for (int i = 3; i <= n; i++)
                {
                    num = num1 + num2;
                    Console.Write("{0}\t", num);
                    num1 = num2;
                    num2 = num;
                }
            }
        }
    }
}
