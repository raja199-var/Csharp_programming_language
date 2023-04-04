using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrderOfEachWordOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
            
        }
    }
}
