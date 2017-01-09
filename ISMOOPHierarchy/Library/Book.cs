using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book:ICloneable,IComparable
    {
        public string nameBook;
        public string Author;

        public Book (string nameBook,string Author)
        {
            this.nameBook=nameBook;
            this.Author=Author;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
            Book b = o as Book;
            if (b != null)
                return this.nameBook.CompareTo(b.nameBook);
            else throw new Exception("error dont compare");
        }
        public void Display()
        {
            Console.WriteLine("Book is: \"{0}\" {1}\'s", nameBook, Author);
        }
    }
}
