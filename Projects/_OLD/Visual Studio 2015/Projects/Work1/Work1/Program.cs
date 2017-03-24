using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Algoritm
    {
        public int Min(int a, int b, int c)
        {
            int sum = a + b;
            int mult = b * c;
            int min = (sum >= mult) ? mult : sum;

            return min;
        }

        public int Max(int a, int b, int c)
        {
            int sum = a + b + c;
            int mult = a * b * c;
            int max = (sum <= mult) ? mult : sum;

            return max;
        }

        public double Excute(int max, int min)
        {
            return max / min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Algoritm alg = new Algoritm();

            int max = alg.Max(a, b, c);
            int min = alg.Min(a, b, c);

            Console.Write("\nMax = ");
            Console.WriteLine(max);
            Console.Write("Min = ");
            Console.WriteLine(min);
            Console.Write("Q = ");
            Console.WriteLine(alg.Excute(max, min));

            Console.ReadLine();
        }
    }
}
