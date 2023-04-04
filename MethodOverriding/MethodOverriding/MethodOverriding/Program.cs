using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
     class Program
    {
      public virtual void test()
        {
            Console.WriteLine("Hello Parent");
        }

    }
     class Demo : Program
    {
        public override void test()
        {
            Console.WriteLine("Hello child");
        }
    
        

    }
    class Result
    {
        public static void Main(string[] args)
        {
            Demo de = new Demo();
            de.test();

            Program p = new Program();
            p.test();

            Program p1 = new Demo();
            p1.test();
            Console.ReadLine();
        }
    }
}
