using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainingOfParameterizedConstructors
{
    internal class Program
    {
       public Program(int x)
        {
            Console.WriteLine("x"+x);
        }

    }
    class Program1:Program
    {
        public Program1(int y):base(20)
        {
            Console.WriteLine("y"+y);
        }

    }
    class Program2:Program1
    {
        public Program2(int z):base(30)
        {
            Console.WriteLine("z"+z);

        }
    }
    class Program3
    {
        public static void Main(string[] args)
        {
            Program2 p = new Program2(10);
            Console.ReadLine();
        }
    }
}
