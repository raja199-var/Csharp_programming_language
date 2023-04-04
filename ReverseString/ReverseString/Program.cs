using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            string str = Console.ReadLine();
            for(int i = str.Length-1; i >=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadLine();
        }
    }
}
