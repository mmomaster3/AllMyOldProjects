using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @is
{
    class User
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }

    class Program
    {
        ///<summary> Main is a
        ///<para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine(System.String)"/> for information about output statements.</para>
        /// <seealso cref="TestClass.Main"/>
        /// </summary>
        static void Main(string[] args)
        {
            User user = new User();
            user.Phone = new Phone { Company = new Company { Name = null } };
            string companyName = user.Phone.Company.Name;

            string result = user.Phone.Company.Name ?? "f";
            Console.WriteLine(result);
            Console.WriteLine(args);
            Console.ReadLine();
        }
    }
}
