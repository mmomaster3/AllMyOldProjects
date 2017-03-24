using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SObesClass
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine('a');
        }
    }
    class B : A
    {
        public void Method1()
        {
            Console.WriteLine('b');
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A v = new B();
            v.Method1();
        }
    }
}
