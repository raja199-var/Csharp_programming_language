using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseEachWordString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string: ");
            char[] str = Console.ReadLine().ToCharArray();
            Console.WriteLine(str[3]);
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i]!=' ')
                {
                    count++;

                    
                }
                else
                {
                    count = 0;
                }
                
            }
            
            
        }
    }
}
