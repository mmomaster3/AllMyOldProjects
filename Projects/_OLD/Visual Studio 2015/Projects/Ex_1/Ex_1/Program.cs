using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string s = Console.ReadLine();

            Console.WriteLine(Uniq(s).Length);
            Console.WriteLine((Vowels(s) > Consinant(s) ? $"Тут {Vowels(s)} гласных и их больше" : $"Тут {Consinant(s)} согласных и их больше"));
            Console.ReadLine();
        }

        private static string Uniq(string s)
        {
            List<char> used = new List<char>();
            StringBuilder uniq = new StringBuilder();
            foreach (char i in s)
            {
                if (used.IndexOf(i) == -1)
                {
                    used.Add(i);
                    uniq.Append(i);
                }
            }
            return uniq.ToString();
        }

        private static int Vowels(string s)
        {
            char[] vowles = "аеёиоуыэюя".ToCharArray();

            int i = 0;
            foreach (char j in s)
            {
                if (vowles.Contains(j))
                    i++;
            }
            return i;
        }

        private static int Consinant(string s)
        {
            char[] consonant = "бвгджзйклмнпрстфхцчшщъь".ToCharArray();

            int i = 0;
            foreach (char j in s)
            {
                if (consonant.Contains(j))
                    i++;
            }
            return i;
        }
    }
}
