using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the two numbers between which you want to find the prime numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            int flag = 0;
            if (num1 == num2)
            {
                Console.WriteLine("Please enter two different numbers: ");

            }
            else if (num1 > num2)
            {
                Console.WriteLine("First number must be lesser than second number.");
            }
            else if (num1 < 0 || num1 < 0)
            {
                Console.WriteLine("Number must be greater  than zero");

            }
            else
            {
                Console.WriteLine("The prime numbers are: ");
                if (num1 == 1 || num1 == 2)
                {
                    Console.WriteLine(2);
                }
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = 2; j <= i - 1; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                        else
                        {
                            flag = 2;
                        }
                    }
                    if (flag == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();


        }
    }
}
