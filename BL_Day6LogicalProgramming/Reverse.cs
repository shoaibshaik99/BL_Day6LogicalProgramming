using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day6LogicalProgramming
{
    internal class Reverse
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a number to reverse it");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;
            int reverse = 0;
            while (n != 0)
            {
                reverse = reverse * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Here is the reversed number: {0}",reverse);
        }
        public static /*void */ string ReverseString(string s)
        {
            //Console.WriteLine("Enter a string to revere");
            //string s = Console.ReadLine();
            //Console.WriteLine(s[2]); // 3rd letter in  the string
            //int count = 0;
            //foreach (char c in s)
            //{
            //    count++;
            //}
            string reverse = "";
            foreach(char c in s)
            {
                reverse = c + reverse;
            }
            //Console.WriteLine(reverse);
            return reverse;
        }

        public static void ReverseEachWordAtItsPositionInString()
        {
            Console.WriteLine("Enter a sentence to reverse each word of the sentence");
            string s = Console.ReadLine();
            string reverse = "";
            //char[] delimiters = { ' ', ',', ':' };
            //string[] word = s.Split(delimiters); // splitting using delimiters
            string[] words = s.Split(' ');
            for (int i = 0; i <words.Length; i++) // foreach(string w in words)
            {
                string r = ReverseString(words[i]);
                reverse = reverse + r + " ";
            }
            Console.Write(reverse);

        }
    }
}
