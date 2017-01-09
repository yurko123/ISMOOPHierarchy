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
        public static void StartElective()
        {
            Console.WriteLine("type a name and last name of pupil");
            string name, lastname;
            Console.Write("Pupil`s name : ");
            name = Console.ReadLine();
            Console.Write("Pupil`s lastname : ");
            lastname = Console.ReadLine();
            Student New = new Student(name, lastname);
            Console.WriteLine("enter number of courses ,course name,  teachers :name , lastname, fathername, experience in years and grade in course");
            Console.Write("number of courses: ");
            int num = int.Parse(Console.ReadLine());
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
                byte grade = byte.Parse(Console.ReadLine());
                arr[i] = new Course(crsname, tname, tlname, tfname, texp);
                arr[i].Grade100 = grade;
            }
            Book t = new Book("sdas", "sda");
            Arhive a = new Arhive(New, arr);
            a.Display();
            Arhive b = (Arhive)a.Clone();
            a.Display();
        }
        public static void StartPayment()
        {
            Teacher q = new Teacher();
            Score x = new Score("Vasya", "Ivanov", "Petrovich", 756655, 5454543, "0000");
            Score a = new Score("Vitya", "Corniychuk", "Azihmundovich", 13323, 543432, "1111");
            x.putMoney(1000, "0000");
            x.PayToScore(500, a, "0000");
            Console.WriteLine(x.Cash);
        }
        public static void StartHospital()
        {
            Doctor x = new Doctor();
            Doctor y = new Doctor();
            Patient n = new Patient("vassy","sdsd","sdsds",x,y,"сancer");
            Patient q = (Patient)n.Clone();
            q.doctor.firstName = "sfdfsd";
            n.Display();
        }
        public static void StartExams()
        {
            Exams[] mas=new Exams[3];
           mas[0] = new Exams("Math", "Тетяна", "Николаева", "Євгенівна", 20, "Fiz-mat");
           mas[0].Grade100 = 50;
            mas[1] = new Exams("Math", "Тетяна", "Николаева", "Євгенівна", 20, "Fiz-mat");
            mas[1].Grade100 = 100;
            mas[2]=(Exams)mas[1].Clone();
            mas[2].Grade100 = 0;
            mas[2].Display();
            Matriculant New = new Matriculant(mas, "polishcuk", "yurii");
           // New.Display();
            ConsoleWriter.Write(New);
            
        }
        public static void StartLibrary() {
            Book mybook = new Book("gameoftrones", "vasya");
            Reader myself = new Reader("yuriy", "kostyantinovich", mybook);
            Reader a = (Reader)myself.Clone();
            myself.Display();
            Console.WriteLine();
            a.Display();
        }
        static void Main(string[] args)
        {
            ConsoleConfig("OOP");
            Console.WriteLine("Menu :\nChoice item\n1)Elective\n2)Payments\n3)Hospital\n4)Exams\n5)Library");
            try { byte num = byte.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: StartElective();
                    break;
                case 2: StartPayment();
                    break;
                case 3: StartHospital();
                    break;
                case 4: StartExams();
                    break;
                case 5: StartLibrary();
                    break;
                default: Console.WriteLine("number out");
                    break;
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        
            Console.ReadKey();
        }
    }
}
