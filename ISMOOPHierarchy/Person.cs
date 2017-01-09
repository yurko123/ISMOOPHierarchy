using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    abstract class Person
    {
        public string firstName;
        public string lastName;
        public string fatherName;
        public DateTime birthDay;
        public Person()
        {
            firstName = "unknown";
            lastName = "unknown";
            fatherName = "unknown";
            birthDay = DateTime.Parse("01.01.1900");
        }
        public Person(string firstName, string lastName):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName, string lastName, string fatherName)
            : this(firstName, lastName)
        {
            this.fatherName = fatherName;
        }
        public Person(string firstName, string lastName, DateTime birthDay)
            : this(firstName,lastName)
        {
            this.birthDay = birthDay;
        }
        public Person(string firstName, string lastName, string fatherName, DateTime birthDay)
            : this(firstName,lastName,firstName)
        {
            this.birthDay = birthDay;
        }
       

        public string GetFullName()
        { return lastName + ' ' + firstName + ' ' + fatherName; }
       
        public abstract void Display();
        
    }
}
