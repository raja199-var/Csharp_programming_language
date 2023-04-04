/*
 * Program to remove duplicate characters from a string using pre-defined method
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string resultstr = String.Empty;
            Console.WriteLine(resultstr);
            for(int i = 0; i < str.Length; i++)
            {
                if (!resultstr.Contains(str[i]))
                {
                    resultstr = resultstr + str[i];
                }

            }
            Console.WriteLine(resultstr);
            Console.ReadLine();
        }
    }
}
