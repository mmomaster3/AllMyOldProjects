using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ang_rus
{
    class Translate
    {
        public Dictionary<string, string[]> dic = new Dictionary<string, string[]>();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Translate t = new Translate();
            var dic = t.dic;

            do
            {
                string[] eng = new string[10];
                Console.Write("Введите слово:");
                string rus = Console.ReadLine();
                Console.Write("Введите переводы через <Пробел>:");
                eng = Console.ReadLine().Split(' ');
                dic.Add(rus, eng);
                Console.Write("Для выхода <Esc>, Для продолжения <AnyKey>\n");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.Write("Введите искомое слово:");
            string word = Console.ReadLine();
            if (dic.ContainsKey(word))
            {
                foreach (var n in dic[word])
                {
                    Console.WriteLine(n);
                }
            }

            //Console.ReadLine();
            do
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Введите первый символ по которому будет произведен поиск по словарю");
                string simbol = Console.ReadLine().ToCharArray().First().ToString();

                var quary =
                    from _dic in dic
                    from value in _dic.Value
                    where _dic.Key.StartsWith(simbol)
                    select "Слово  = " + _dic.Key + " Перевод = " + value;

                Console.WriteLine(new string('-', 50));

                foreach (var n in quary)
                {
                    Console.WriteLine(n);
                }

                Console.Write("Для выхода <Esc>, Для продолжения <AnyKey>\n");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.ReadLine();
        }
    }
}
