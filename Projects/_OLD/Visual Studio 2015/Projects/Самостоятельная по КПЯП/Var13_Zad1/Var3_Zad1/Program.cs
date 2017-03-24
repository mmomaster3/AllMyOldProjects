using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var3_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во цифр");
            int n = Int32.Parse(Console.ReadLine());
            int i = 0;
            int s = 0;
            do
            {
                if (i % 2 != 0)
                    s += i;
                i++;
            }
            while (i < n);
            Console.WriteLine("Сумма чисел " + s);
            Console.ReadLine();
        }
    }
}
