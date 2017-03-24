using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7] { 8, 7, 0, 9, 9, 2, 6};
            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(10);
                Console.WriteLine(a[i]);
            }
            int f = int.MaxValue, s = f;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < f)
                {
                    s = f;
                    f = a[i];
                }
                else if (a[i] < s)
                {
                    s = a[i];
                }
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(f +"\n" + s);
        }
    }
}
