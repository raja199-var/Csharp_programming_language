using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strAge = "raja";
            bool checkResult = int.TryParse(strAge, out int age);

            if (checkResult == true)
            {
                Console.WriteLine($"String is a valid number. The value is: {age}");
            }
            else
            {
                Console.WriteLine("String is not a valid number.");
            }
            Console.ReadLine();
        }
    }
}
