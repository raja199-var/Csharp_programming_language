using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 for addition: ");
                Console.WriteLine("Enter 2 for subtraction: ");
                Console.WriteLine("Enter 3 for multiply: ");
                Console.WriteLine("Enter 4 for division: ");
                Console.WriteLine("Enter 5 for exit: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter two numbers: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = a + b;
                        Console.WriteLine("sum is " + c);
                        break;
                    case 2:
                        Console.WriteLine("Enter two numbers: ");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        int n3 = n1- n2;
                        Console.WriteLine("sum is " + n3);
                        break;
                    case 3:
                        Console.WriteLine("Enter two numbers: ");
                        int n = int.Parse(Console.ReadLine());
                        int m = int.Parse(Console.ReadLine());
                        int m1 = m*n;
                        Console.WriteLine("sum is " + m1);
                        break;
                    case 4:
                        Console.WriteLine("Enter two numbers: ");
                        double x= int.Parse(Console.ReadLine());
                        double y = int.Parse(Console.ReadLine());
                        double z = x/y;
                        Console.WriteLine("sum is " + z);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;


                }
            }



        }
    }
}
