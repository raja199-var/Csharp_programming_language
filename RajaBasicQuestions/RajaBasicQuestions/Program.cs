using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajaBasicQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0, i = 0;
            int[] digit = new int[10];
            int tempnum = num;
            while (num > 0)
            {
                digit[i++] = num % 10;
                count = count + 1;
                num = num / 10;

            }

            for (int j = 0; j < count; j++)
            {
                sum += Math.Pow(digit[j], count);
            }
            if (sum == tempnum)
            {
                Console.WriteLine("it is an armstrong number. ");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }
            Console.ReadLine();
        }
    }
}
