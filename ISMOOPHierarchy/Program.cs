using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Program
    {

        public static void ConsoleConfig(string title)
        {
            Console.Title = title;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.GetEncoding(1251); // може буть несумісність кодувань
            Console.InputEncoding = Encoding.GetEncoding(1251);
        }
        static void Main(string[] args)
        {
            ConsoleConfig("OOP");
            Console.WriteLine("type a name and last name of pupil");
            string name, lastname;
            Console.Write("Pupil`s name : ");
            name= Console.ReadLine();
            Console.Write("Pupil`s lastname : ");
            lastname = Console.ReadLine();
            Student New = new Student(name,lastname);
            Console.WriteLine("enter number of courses ,course name,  teachers :name , lastname, fathername, experience in years and grade in course");
            Console.Write("number of courses: ");
            int num=int.Parse(Console.ReadLine());
            Course[] arr = new Course[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Course name : ");
                string crsname = Console.ReadLine();
                Console.Write("teachers name : ");
                string tname = Console.ReadLine();
                Console.Write("teachers lastname : ");
                string tlname = Console.ReadLine();
                Console.Write("teachers father name : ");
                string tfname = Console.ReadLine();
                Console.Write("teachers experience : ");
                int texp = int.Parse(Console.ReadLine());
                Console.Write("Grade : ");
                int grade = int.Parse(Console.ReadLine());
                arr[i] = new Course(crsname, tname, tlname, tfname, texp);
                arr[i].Grade100=grade;
            }
       



            Arhive a = new Arhive(New, arr);
            a.Display();
            Console.ReadKey();
        }
    }
}
