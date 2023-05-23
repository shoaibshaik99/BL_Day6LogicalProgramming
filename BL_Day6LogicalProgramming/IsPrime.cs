using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day6LogicalProgramming
{
    internal class IsPrime
    {
        public static void Prime()
        {
            Console.Write("Enter a number to check if it is a prime number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine("{0} is not prime", n);
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("{0} is not prime", n);
                    return;
                }
            }
            Console.WriteLine("{0} is prime", n);
        }
    }
}
