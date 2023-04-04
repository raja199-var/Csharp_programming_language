using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int i, place=0;
            Console.WriteLine("enter the elements of the array: ");
            for( i = 0; i < size; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());
                
            }
            int max1 = arr[0];
            for( i = 1; i < size; i++)
            {
                if (max1 < arr[i])
                {
                    max1 = arr[i];
                    place = i;
                   

                }
            }
          //  Console.WriteLine("The position of first max element is" + place);
            
            //Console.WriteLine("The first maximum element is" + max1);
            for(int j = place; j < size - 1; j++)
            {
                arr[j] = arr[j + 1];
                
            }
           /* for(int j = 0; j < size - 1; j++)
            {
                Console.WriteLine(arr[j]);
            }*/
            int max2 = arr[0];
            for(int j = 0; j < size - 1; j++)
            {
                if (max2 < arr[j])
                {
                    max2 = arr[j];
                }
            }

            Console.WriteLine("The second largest element is " + max2);
            Console.ReadLine();


        }
    }
}
