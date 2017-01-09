using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Hospital
{
    class Doctor:Person,ICloneable,IComparable
    {
        public string rank{get;set;}
        public Doctor()
            : base()
        { }
            public Doctor(string firstName,string lastName,string fatherName,string rank)
            {
                this.rank = rank;
            }
            public object Clone()
            {
                return this.MemberwiseClone();
            }
            public int CompareTo(object o)
            {
                Doctor d = o as Doctor;
                if (d != null)
                    return this.firstName.CompareTo(d.firstName);
                else throw new Exception("error dont compare");
            }
            public override void Display()
            {
                Console.WriteLine("Doctor: {0} {1} {2} rank is: {3}", firstName, lastName, fatherName, rank);
            }
        
    }
}
