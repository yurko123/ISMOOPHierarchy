using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elective;

namespace Exam
{
    class Exams:Course,ICloneable,IComparable
    {
        protected string faculty;
        public Exams(string examName, string teachersFirstName, string teachersLastName, string teachersFatherName, int experience, string faculty)
            : base(examName, teachersFirstName, teachersLastName, teachersFatherName, experience) 
        {
            this.faculty = faculty;

            

        }
       public object Clone()
        {
            return this.MemberwiseClone();
        }
       public int CompareTo(object o)
       {
           Exams e = o as Exams;
           if (e != null)
               return this.faculty.CompareTo(e.faculty);
           else throw new Exception("error dont compare");
       }
        public override void Display()
        {
            Console.WriteLine("Teacher Is : {0} {1}  Experience: {2}", firstName, fatherName, experience);
            Console.WriteLine("Grade in exam \"{0}\" : {1} points", NameCourse, Grade);

        }
    }
}
