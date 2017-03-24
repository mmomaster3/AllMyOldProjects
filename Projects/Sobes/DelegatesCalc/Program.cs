using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalc
{
    class Calc
    {
        private Dictionary<string, Func<double, double, double>> _operations = new Dictionary<string, Func<double, double, double>>
        {
            {"+", (x,y) => x+ y },
            { "-", (x,y) => x- y }
        };
        public Calc()
        {


        }
        //public static double PreformOp(string op, double x, double y)
        //{
        //    switch (op)
        //    {
        //        case "+": return x + y;
        //        case "-": return x - y;
        //        default: throw new ArgumentException(string.Format("net operatora"));
        //    }
        //}
        public double PreformOp(string op, double a, double b)
        {
            return _operations[op](a, b);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Calc calc = new Calc();
            var rez = calc.PreformOp("+", 5, 6);
            //double rez = PreformOp("+", 5, 11);
            Console.WriteLine(rez);

        }
    }
}
