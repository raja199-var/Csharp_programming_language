using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeftCircularRotationInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int x = arr[0];
            for (int i = 1; i <= size-1; i++)
            {
                arr[i-1] =arr[i];
            }
            arr[size - 1] = x;
          
           

            Console.WriteLine("Resulted array is: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.ReadLine();
        }
    }
}
