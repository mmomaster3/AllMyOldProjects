using System;
using System.Linq;
using System.IO;

namespace DirectoryIO
{
    class Program
    {
        //поменял
        static char[] eng = new char[] { 'А', 'а', 'В', 'е', 'Е', 'З', 'И', 'К', 'к', 'М', 'н', 'Н', 'О', 'о', 'Р', 'р', 'С', 'с', 'Т', 'у', 'Х', 'х', 'Т', 'т' };
        static char[] rus = new char[] { 'A', 'a', 'B', 'e', 'E', '3', 'N', 'K', 'k', 'M', 'h', 'H', 'O', 'o', 'P', 'p', 'C', 'c', 'T', 'y', 'X', 'x', 'T', 't' };

        static void Main(string[] args)
        {
            Console.WriteLine("Если вы не на ПК, включите wi-fi kbp, и жми на Enter");
            Console.ReadLine();

            string path = @"\\S1\сдавать";

            DirectoryInfo[] di = new DirectoryInfo(path).GetDirectories();
            foreach (var item in di)
            {
                Console.WriteLine(item);
            }
            //Console.ReadLine();

            string tmp;
            for (int i = 0; i < di.Count(); i++)
            {
                start = 0;
                for (int j = 0; j < di[i].ToString().Length; j++)
                {
                    tmp = di[i].ToString();

                    DirectoryInfo d = Directory.CreateDirectory(path + @"\" + Check(tmp) ?? "");
                }
            }

            //Console.ReadLine();
        }

        public static int start = 0;

        public static string Check(string s)
        {
            char[] sChar = s.ToCharArray();

            for (int i = start; i < sChar.Length; i++)
            {
                for (int j = 0; j < eng.GetLength(0); j++)
                {
                    if (sChar[i] == eng[j])
                    {
                        sChar[i] = rus[j];
                        start = i + 1;
                        return new string(sChar);
                    }
                }
            }
            return null;
        }
    }
}
