using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day6LogicalProgramming
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            Console.Write("Enter a number to check if it is a perfect number or not: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("{0} is a perfect number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", n);
            }

        }
    }
}
