using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Library
{
    class Reader:Person,ICloneable,IComparable
    {
       
        protected Book book;
        public bool isBlackList { get; set; }
        public Reader(string firstName, string lastName, Book book)
            : base(firstName, lastName)
        {
            this.book = book;
            isBlackList = false;
        }


        public object Clone()
        {
            Book a = new Book("def", "def");
            return new Reader ("unknown","unknown",a){birthDay = this.birthDay, book = (Book)this.book.Clone(), fatherName = this.fatherName, firstName = this.firstName, lastName = this.lastName };
        }
        public int CompareTo(object o)
        {
            Reader r = o as Reader;
            if (r != null)
                return this.firstName.CompareTo(r.firstName);
            else throw new Exception("error dont compare");
        }
        public override void Display()
        {
            Console.Write("Reader is: {0} {1} Book is: \"{2}\"", firstName, lastName, book.nameBook);
            if (isBlackList) Console.WriteLine("IN BLACKLIST !!!!");
        }
    }
}
