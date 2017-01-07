using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective
{
    class Arhive
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

        public void Display()
        {
            student.Display();
            for (int i = 0; i < course.Length; i++)
                course[i].Display();

        }

        
    }
}
