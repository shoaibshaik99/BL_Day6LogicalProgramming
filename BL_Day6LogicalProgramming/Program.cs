namespace BL_Day6LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run");
            Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Is it prime?\n4.Reverse a number\n5.Coupon Numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries.PrintFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    IsPrime.Prime();
                    break;
                case 4:
                    Reverse.ReverseNumber();
                    //Reverse.ReverseEachWordAtItsPositionInString();
                    break;
                case 5:
                    CouponNumbers.CouponNumber();
                    //Reverse.ReverseEachWordAtItsPositionInString();
                    break;
                default:
                    Console.WriteLine("Incorrect input, program ends here");
                    break;
            }

        }
    }
}