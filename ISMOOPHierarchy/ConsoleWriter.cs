using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elective;
using Exam;
using Hospital;
using Library;
using Payment;

namespace ISMOOPHierarchy
{
    static class ConsoleWriter
    {
        public static void Write(Teacher t)
        {
            t.Display();
        }
        public static void Write(Student s)
        {
            s.Display();
        }
        public static void Write(Course c)
        {
            c.Display();
        }
        public static void Write(Arhive a)
        {
            a.Display();
        }
        public static void Write(Exams e)
        {
            e.Display();
        }
        public static void Write(Matriculant m)
        {
            m.Display();
        }
        public static void Write(Doctor d)
        {
            d.Display();
        }
        public static void Write(Patient p)
        {
            p.Display();
        }
        public static void Write(Book b)
        {
            b.Display();
        }
        public static void Write(Reader r)
        {
            r.Display();
        }
        public static void Write(Client c)
        {
            c.Display();
        }
        public static void Write(Score s)
        {
            s.Display();
        }
    }
}
