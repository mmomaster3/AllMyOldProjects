using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var13_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите h");
            int h = Int32.Parse(Console.ReadLine());
            double y = 0;
            for (int i = a; i <= b; i+=h)
            {
                y = Math.Sqrt(i - 4) + Math.Pow(Math.E, i);
                Console.WriteLine("Функция" + y);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
