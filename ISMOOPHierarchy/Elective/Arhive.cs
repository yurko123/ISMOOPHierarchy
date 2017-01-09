using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective
{
    class Arhive:ICloneable,IComparable
    {
        protected Student student;
        protected Course[] course;

        public Arhive()
        {
            student = new Student();
            course = new Course[1];
            course[0] = new Course();
        }
        public Arhive(Student student, Course[] course)
        {
            this.student = student;
            this.course = course;
        }
        public int CompareTo(object o)
        {
            Arhive a = o as Arhive;
            if (a != null)
                return this.student.firstName.CompareTo(a.student.firstName);
            else throw new Exception("error dont compare");
        }
        public void Display()
        {
            student.Display();
            for (int i = 0; i < course.Length; i++)
                course[i].Display();

        }
        public object Clone()
        {
            return new Arhive { student = this.student, course = this.course };
        }
       

        
    }
}
