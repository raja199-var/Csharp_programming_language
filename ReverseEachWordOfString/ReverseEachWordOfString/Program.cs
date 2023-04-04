using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            string result = string.Empty;
           /* foreach(string a in arr)
            {
                Console.WriteLine(a);
                result += reverseString(a) + " ";
            }
            Console.WriteLine(result);
            Console.ReadLine();*/
           for(int i = 0; i <arr.Length; i++)
            {
                result+= reverseString(arr[i])+" ";
               
            }
            Console.WriteLine(result);   
            Console.ReadLine();
            

        }
        static string reverseString(string str)
        {
            string result1 = "";
            for(int i = str.Length-1; i>=0; i--)
            {
                result1+= str[i] ;

            }
            return result1;
        }
    }
}
