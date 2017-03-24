using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floid
{
    class Program
    {
        static void Main(string[] args)
        {
            // int con = int.MaxValue;
            int[,] mas = new int[10, 10];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i != j)
                        mas[i, j] = 99999;
                }
            }

            mas[0, 1] = 10;
            mas[0, 2] = 30;
            mas[0, 4] = 10;
            mas[1, 2] = 45;
            mas[3, 2] = 20;
            mas[4, 0] = 10;
            mas[5, 3] = 35;
            mas[6, 7] = 10;
            mas[8, 3] = 20;
            mas[2, 4] = 15;
            mas[3, 6] = 1;
            mas[4, 3] = 30;
            mas[5, 9] = 10;
            mas[7, 2] = 100;
            mas[8, 6] = 5;
            mas[3, 1] = 40;
            mas[3, 8] = 20;
            mas[4, 5] = 5;
            mas[6, 3] = 1;
            mas[8, 6] = 5;
            mas[9, 8] = 50;


            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", mas[i, j]);
                }
                Console.WriteLine();
            }

            for (int k = 0; k < mas.GetLength(0); k++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] > mas[i, k] + mas[k, j])
                        {
                            mas[i, j] = mas[i, k] + mas[k, j];
                        }
                    }
                }
            }
            
            Console.WriteLine("Вывод: ");
            Console.WriteLine("      1   2   3   4   5   6   7   8   9  10");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write(i + 1 + "| ");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,4}", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
