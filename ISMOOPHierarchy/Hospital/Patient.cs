﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Hospital
{
    class Patient : Person,ICloneable,IComparable
    {
        public Doctor doctor;
        public Doctor secondDoctor;
        protected bool discharged;
        protected string destination;

        public Patient()
            : base()
        { }
        public Patient(string firstName, string lastName, string fatherName, Doctor doctor, Doctor secondDoctor, string destination)
            : base(firstName, lastName, fatherName)
        {
            this.doctor = doctor;
            this.secondDoctor = secondDoctor;
            this.destination = destination;
            discharged = false;
        }

        public void dischargedPatient()
        {
            discharged = true;
        }
        public object Clone()
        {
            return new Patient { birthDay = this.birthDay, destination = this.destination, discharged = this.discharged, fatherName = this.fatherName, firstName = this.firstName, lastName = this.lastName, doctor = (Doctor)this.doctor.Clone(), secondDoctor = (Doctor)this.secondDoctor.Clone() };
        }
        public int CompareTo(object o)
        {
            Patient p = o as Patient;
            if (p != null)
                return this.firstName.CompareTo(p.firstName);
            else throw new Exception("error dont compare");
        }
        public override void Display()
        {
            Console.WriteLine("Patient is : {0} {1} {2}", firstName, lastName, fatherName);
            doctor.Display();
            Console.Write("Second ");
            secondDoctor.Display();
            Console.Write(destination);
            if (discharged) Console.Write(" discharged");
        }
    }
}















































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































