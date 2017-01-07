using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy;

namespace Exam
{
    class Matriculant:Person
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
        public override void Display()
        {
            Console.WriteLine("Matriculant is : {0} {1} , Average: {2}", firstName, lastName, avrgGrade);
        }
    }
}
