using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Library
{
    class Reader:Person
    {
       
        protected Book book;
        public bool isBlackList { get; set; }
        public Reader(string firstName, string lastName, Book book)
            : base(firstName, lastName)
        {
            this.book = book;
            isBlackList = false;
        }


        
        public override void Display()
        {
            Console.Write("Reader is: {0} {1} Book is: \"{2}\"", firstName, lastName, book.nameBook);
            if (isBlackList) Console.WriteLine("IN BLACKLIST !!!!");
        }
    }
}
