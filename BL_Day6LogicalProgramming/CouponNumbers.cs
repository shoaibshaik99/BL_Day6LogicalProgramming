using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BL_Day6LogicalProgramming
{
    internal class CouponNumbers
    {
        public static void CouponNumber()
        {
            Console.WriteLine("Please enter the total number of coupons numbers you want to generate: ");
            int noOfCoupons = Convert.ToInt32(Console.ReadLine());
            int[] couponNumbers = new int[noOfCoupons]; //array to store distinct coupon numbers

            Random random = new Random();
            int countOfDistinct = 0; // it also acts as index, hence actual count of distinct elements is countOfDistinct+1
            int r = random.Next(0, noOfCoupons + 1);
            couponNumbers[countOfDistinct] = r;
            int countOfIterations = 1;
            //Console.WriteLine(countOfIterations + ", " + r);

            while (countOfDistinct < noOfCoupons)
            {
                bool valueOccured = false;
                r = random.Next(1, noOfCoupons + 1);
                countOfIterations++;
                //Console.WriteLine(countOfIterations + ", " + r);
                for (int i = 0; i < noOfCoupons/*<=countOfDistinct*/; i++)
                {
                    if (couponNumbers[i] == r)
                    {
                        valueOccured = true;
                        break;
                    }
                }
                if (valueOccured)
                {
                    continue;
                }
                couponNumbers[countOfDistinct] = r;
                countOfDistinct++;
            }
            Console.WriteLine("Total number of iterations requried to generate {0} distinct numbers are {1}", noOfCoupons, countOfIterations);
            Console.WriteLine("Here is the respective array generated:\n");
            for (int i = 0;i < noOfCoupons; i++)
            {
                Console.Write(couponNumbers[i] + " ");
            }
        }
    }
}