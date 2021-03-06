﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Elective
{
    class Student:Person,ICloneable,IComparable
    {
        
        
        protected string GradeBookNum{get; set;}
        protected string PhoneNumber{get; set;}

        
        
        
       public Student():base()
        {
            GradeBookNum = "not";
            PhoneNumber = "not";
        }

        public Student(string firstName, string lastName)
            : base(firstName,lastName)
        {
            GradeBookNum = "not";
            PhoneNumber = "not";
        }

        public Student(string firstName, string lastName, string fatherName)
            : base(firstName,lastName,fatherName)
        {
            GradeBookNum = "not";
            PhoneNumber = "not";
        }
        public Student(string firstName, string lastName, string fatherName, DateTime birthDay)
            : base(firstName, lastName, fatherName, birthDay)
        {
            GradeBookNum = "not";
            PhoneNumber = "not";
        }

        public Student(string firstName, string lastName, string fatherName, string GradeBookNum, string PhoneNum)
            : this(firstName, lastName, fatherName)
        {
            this.GradeBookNum = GradeBookNum;
            this.PhoneNumber = PhoneNum;
        }

        public Student(string firstName, string lastName, string fatherName, DateTime birthDay, string GradeBookNum, string PhoneNum):this(firstName,lastName,fatherName,birthDay)
        {
            this.GradeBookNum = GradeBookNum;
            this.PhoneNumber = PhoneNum;
        }

        public Student(Student student)
        {
            this.firstName = student.firstName;
            this.lastName = student.lastName;
            this.fatherName = student.fatherName;
        }


        public object Clone()
        {
            return new Student { firstName = this.firstName, lastName = this.lastName, fatherName = this.fatherName, birthDay = this.birthDay,GradeBookNum=this.GradeBookNum,PhoneNumber=this.PhoneNumber};
        }
        public int CompareTo(object o)
        {
            Student s = o as Student;
            if (o != null)
                return this.firstName.CompareTo(s.firstName);
            else throw new Exception("error dont compare");
        }
        public override void Display()
        {
            Console.WriteLine("Student Is : {0} {1}", lastName, firstName);
        }
        


    }
}
