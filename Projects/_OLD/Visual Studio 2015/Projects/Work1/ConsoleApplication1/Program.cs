using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[,] { };
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mas[i, j] = 5;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(i< j)  mas[i, j] = 1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
