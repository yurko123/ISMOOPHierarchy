﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Elective
{
    class Teacher:Person,ICloneable,IComparable
    {
        public int experience { get; set; }


        public Teacher():base()
        {
            experience = 0;
        }

        public Teacher(string firstName, string lastName)
            : base(firstName,lastName)
        {
            experience = 0;
        }

        public Teacher(string firstName, string lastName, string fatherName)
            : base(firstName,lastName,fatherName)
        {
            experience = 0;
        }
        public Teacher(string firstName, string lastName, string fatherName, DateTime birthDay)
            : base(firstName, lastName, fatherName, birthDay)
        {
            experience = 0;
        }

        public Teacher(string firstName, string lastName, string fatherName, int experience)
            : this(firstName, lastName, fatherName)
        {
            this.experience = experience;
        }

        public Teacher(string firstName, string lastName, string fatherName, DateTime birthDay, int experience)
            : this(firstName, lastName, fatherName, birthDay)
        {
            this.experience = experience;
        }
        public static implicit operator int(Teacher t)
        {
            return t.experience;
        }

        public object Clone()
        {
            return new Teacher { firstName = this.firstName, lastName = this.lastName, fatherName = this.fatherName, birthDay = this.birthDay, experience = this.experience };
        }
        public int CompareTo(object o)
        {
            Teacher t = o as Teacher;
            if (t != null)
                return this.firstName.CompareTo(t.firstName);
            else throw new Exception("error dont compare");
        }

        public override void Display()
        {
           Console.WriteLine("Teacher Is : {0} {1}  Experience: {2}",firstName,fatherName,experience);
        }
        public override string ToString()
        {
            return firstName + " " + fatherName;
        }
    }
}
