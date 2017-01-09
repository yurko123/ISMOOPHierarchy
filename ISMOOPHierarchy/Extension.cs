using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elective;
using Library;

namespace ISMOOPHierarchy
{
    static class Extension
    {
       
         /// <summary>
        /// addExperience() добавлення досвіду(+1 рік)
         /// </summary>
        
        public static void addExperience(this Teacher t)
        {
            t.experience++;
          
        }
/// <summary>
/// Вік вчителя
/// </summary>
/// <param name="t"></param>
/// <param name="CurentYear">Поточний рік</param>
/// <returns> Вік</returns>
        public static int Age (this Teacher t,int CurentYear)
        {
            return CurentYear - t.birthDay.Year;
        }
    


        /// <summary>
        /// Метод для добавлення автора книги 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="Author">ПІБ автора</param>
        public static void addAuthor(this Book b,string Author)
        {
            b.Author+=" "+Author;

        }
        /// <summary>
        /// Добавлення авторів інших книг
        /// </summary>
        /// <param name="b"></param>
        /// <param name="AuthorsOtherBook">Екземпляр типу Book </param>
        public static void addAuthor(this Book b, Book AuthorsOtherBook)
        {
            b.Author = AuthorsOtherBook.Author;
        }

       
    }
}
