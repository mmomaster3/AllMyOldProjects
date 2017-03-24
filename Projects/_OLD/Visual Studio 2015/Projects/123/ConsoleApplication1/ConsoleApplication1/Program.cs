using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(Display);
            task.Start();
            Console.WriteLine("Выполняется работа метода Main");
            task.Wait();
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Начало работы метода Display");
            // имитация работы метода
            Thread.Sleep(3000);

            Console.WriteLine("Завершение работы метода Display");
        }
    }
}
