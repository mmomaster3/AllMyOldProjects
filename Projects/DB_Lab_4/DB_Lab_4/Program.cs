using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 1;

            for (int x = 3; x < 10; x++)
            {
                if (x > 4)
                {
                    y = Math.Pow(x, 2) + 5.35;
                    Console.WriteLine("x>4    " + y);
                }
                else
                {
                    y = (Math.Sqrt(3 * x - 6.6)) / (Math.Tan(x));
                    Console.WriteLine("x<=4   " + y);
                }
            }
            Console.ReadLine();

        }
    }
}
