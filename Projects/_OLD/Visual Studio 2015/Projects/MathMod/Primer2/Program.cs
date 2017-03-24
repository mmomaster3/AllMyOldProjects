using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int n, i, k;
            double R, SF, SK, x, y;

            Console.WriteLine("Радиус");

            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Всего точек");
            n = Convert.ToInt32(Console.ReadLine());

            i = 1;
            k = 0;

            while (i <= n)
            {
                x = r.NextDouble() * R;
                y = r.NextDouble() * R;

                if ((x * x) + (y * y) <= (R * R))
                    k++;
                i++;
            }

            SK = Math.PI * (R * R);
            SF = SK * k / n;

            Console.WriteLine("Площадь {0}", SF);

            Console.ReadLine();

        }
    }
}
