using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = new Database1Entities();

            foreach (var person in content.Table)
            {
                Console.WriteLine($"{person.Id}: Name - {person.Name} Age - {person.Age}");
            }
        }
    }
}
