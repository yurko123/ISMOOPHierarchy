using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string nameBook;
        public string Author;

        public Book (string nameBook,string Author)
        {
            this.nameBook=nameBook;
            this.Author=Author;
        }
        public void Display()
        {
            Console.WriteLine("Book is: \"{0}\" {1}\'s", nameBook, Author);
        }
    }
}
