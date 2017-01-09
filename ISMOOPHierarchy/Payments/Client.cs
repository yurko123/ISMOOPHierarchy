using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Payment
{
    class Client:Person,ICloneable,IComparable
    {

        public Client(string firstName, string lastName, string fatherName)
            : base(firstName, lastName, firstName)
        { }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
            Client c = o as Client;
            if (c != null)
                return this.firstName.CompareTo(c.firstName);
            else throw new Exception("error dont compare");
        }
        public override void Display()
        {
            Console.WriteLine("Client : {0} {1} {2}", firstName, lastName, fatherName);
        }
    }
}
