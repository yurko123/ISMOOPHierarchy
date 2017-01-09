using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam;

namespace Elective
{
    class Course : Teacher ,IGradeble,ICloneable,IComparable
    {
        protected string NameCourse;
        public byte Grade;

        public Course():base()
        {
            NameCourse = "Default";
            Grade = 0;
        }
        public Course(string NameCourse ,string firstName, string lastName, string fatherName, int experience):base(firstName,lastName,fatherName,experience)
        {
            this.NameCourse = NameCourse;
            Grade = 0;
        }

        public byte Grade100
        {
            get
            {
                return Grade;
            }
            set
            {
                if (value <= 100 && value >= 0)
                    Grade = value;
            }
        }
        public byte Grade5
        {
            get
            {
                if (Grade < 60) return 2;
                else if (Grade < 74) return 3;
                else if (Grade < 90) return 4;
                else return 5;
            }

        }
        public string GradeFive
        {
            get
            {
                if (Grade < 60) return "two";
                else if (Grade < 74) return "three";
                else if (Grade < 90) return "four";
                else return "five";
            }

        }

        public string GetNameCourse()
        {
            return NameCourse;
        }

        
        public int PrintGrade()
        {
            return Grade;
            
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
            Course c = o as Course;
            if (c != null)
                return this.NameCourse.CompareTo(c.NameCourse);
            else throw new Exception("error dont compare");
        }
        
        public override void Display()
        {
            Console.WriteLine("Teacher Is : {0} {1}  Experience: {2}", firstName, fatherName, experience);
            Console.WriteLine("Grade in course \"{0}\" : {1} points", NameCourse ,Grade);

        }
      



    }
}
