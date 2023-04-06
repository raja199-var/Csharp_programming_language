/*
 * Program to show the concept of constructor chaining i.e order of default constructors
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Hello GrandParent");
        }
    }
    class Program1:Program
    {
        public Program1()
        {
            Console.WriteLine("Hello Parent");
        }

    }
    class Program2 : Program1
    {
        public Program2()
        {
            Console.WriteLine("Hello child");
        }
    }
       
    class Program3
    {
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            Console.ReadLine();
            
        }
        
    }
        
          
}
