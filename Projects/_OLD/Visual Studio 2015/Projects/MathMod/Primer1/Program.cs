using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int n,i,k;
            double a, SF, SK, x, y;

            Console.WriteLine("катет");

            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Всего точек");
            n = Convert.ToInt32(Console.ReadLine());

            i = 1;
            k = 0;

            while (i <= n)
            {
                x = r.NextDouble() * a;
                y = r.NextDouble() * a;

                Console.WriteLine($"{x}   {y}");

                if ((y<= a-x) && (y>=0) && (x>=0) )
                {
                    k++;
                }
                i++;
            }

            Console.WriteLine($"n = {n}  K = {k}");
            SK = a * a;
            SF = SK * ((double)k / n);

            Console.WriteLine("Площадь {0}", SF);

            Console.ReadLine();
        
        }
    }
}
