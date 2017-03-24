using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class Program
    {
        public static int Func()
        {
            try
            {
                int b = 22;
                int i = b / 0;
                return 20;
            }
            catch(Exception ex)
            {
                return 10;
            }
            catch(Exception ex)
            {
                return 30;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int b = 22;
                int i = b / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1");
            }
            catch (DivideByZeroException ziro)
            {
                Console.WriteLine("2");
            }
            Console.ReadLine();
        }
    }
}
