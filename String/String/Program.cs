using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string in small letters: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
            Console.ReadLine();
        }
    }
}
