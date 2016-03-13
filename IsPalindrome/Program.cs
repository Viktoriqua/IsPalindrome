using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program allows you to find out, if your string is palindrome or not");
            Console.WriteLine("Please write your string for check");
            string theString;
            while (true)
            {
                theString = Console.ReadLine();

                if (theString!= String.Empty)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please write your string for check");
                }
            }
            if (CheckPalindrome.IsPalindrome(theString))
            {
                Console.WriteLine("Your string is palindrome");
            }
            else
            {
                Console.WriteLine("Your string is not palindrome");
            }
            Console.Read();
        }
    }
}
