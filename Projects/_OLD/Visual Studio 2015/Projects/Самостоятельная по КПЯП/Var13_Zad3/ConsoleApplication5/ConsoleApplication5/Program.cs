using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            int x = Int32.Parse(Console.ReadLine());
            double y = 0;
            int g = 1;
            int f = 3;
            int k = 1;
            for (int i = 1; i< n; i++)
            {
                y = (Math.Pow(x, i + 2)) / (i * (i + 2));
                Console.WriteLine("Func " + y);
                if (i % 2 != 0)
                {
                    y += y;
                }
                else y -= y;
                g++;
                f++;

            }
            Console.ReadLine();
        }
    }
}
