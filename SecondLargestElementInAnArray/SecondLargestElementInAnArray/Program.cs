/*
 * program to find second largest element in an array using built-in methods Sort() and Reverse()
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElementInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array: ");
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("The second largest element is " + arr[1]);
            Console.ReadLine();
        }
     

    }
}
