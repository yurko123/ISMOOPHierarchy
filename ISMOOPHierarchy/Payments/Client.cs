using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Payment
{
    class Client:Person
    {

        public Client(string firstName, string lastName, string fatherName)
            : base(firstName, lastName, firstName)
        { }
        public override void Display()
        {
            Console.WriteLine("Client : {0} {1} {2}", firstName, lastName, fatherName);
        }
    }
}
