using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Exam
{
    class Matriculant:Person,ICloneable,IComparable
    {
        protected Exams[] exams;
        protected double avrgGrade;
        public Matriculant(Exams[] exams, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.exams = exams;
            avrgGrade = 0;
            int len=exams.Length;
            for (int i = 0; i < len; i++)
                avrgGrade += (double)exams[i].Grade / len;

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
           Matriculant m = o as Matriculant;
            if (m != null)
                return this.avrgGrade.CompareTo(m.avrgGrade);
            else throw new Exception("error dont compare");
        }
        public override void Display()
        {
            Console.WriteLine("Matriculant is : {0} {1} , Average: {2}", firstName, lastName, avrgGrade);
        }
    }
}
