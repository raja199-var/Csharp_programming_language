using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharOccurenceInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            int j, count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count = 0;
                for (j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        
                        count++;

                    }
                }
                Console.Write(str[i] + ":");
              
                
                Console.WriteLine(count);
                
               
            }
            Console.ReadLine();
        }
    }
}
