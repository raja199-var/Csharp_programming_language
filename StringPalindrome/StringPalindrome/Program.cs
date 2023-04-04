using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            string revstr = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i].ToString();
            }
            if (revstr == str)
            {
                Console.WriteLine("it is in palindrome. ");
            }
            else
            {
                Console.WriteLine("Not in palindrome");
            }
            Console.ReadLine();
        }    
    }
}
