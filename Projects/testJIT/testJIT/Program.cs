using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testJIT
{
    class B
    {

    }
    class D : B
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //D d = (D)b;
            Object o1 = new Object();
            D b5 = (D)o1;
            Console.ReadLine();
        }
    }

}
