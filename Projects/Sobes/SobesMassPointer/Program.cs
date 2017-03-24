using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobesMassPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            unsafe
            {
                int length = 7;
                int* mass = stackalloc int[length];
                for (int i = 0; i < length; i++)
                {
                    mass[i] = r.Next(10);
                }
                for (int i = 0; i < length; i++)
                {

                }

            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
