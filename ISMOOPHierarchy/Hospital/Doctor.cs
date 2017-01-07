using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Hospital
{
    class Doctor:Person
    {
        public string rank{get;set;}
        public Doctor()
            : base()
        { }
            public Doctor(string firstName,string lastName,string fatherName,string rank)
            {
                this.rank = rank;
            }
            public override void Display()
            {
                Console.WriteLine("Doctor: {0} {1} {2} rank is: {3}", firstName, lastName, fatherName, rank);
            }
        
    }
}
