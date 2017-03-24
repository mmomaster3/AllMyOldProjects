using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _yield
{
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class Library
    {
        private Book[] books;

        public Library()
        {
            books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
            new Book("Евгений Онегин") };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
        public IEnumerable GetBooks(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            foreach (Book b in library.GetBooks(5))
            {
                Console.WriteLine(b.Name);
            }
        }
    }
}
