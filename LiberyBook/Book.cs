using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace LibraryBook 
{
   public class Book
    {
        private static int _LastId;
        public int Id { get; }
        public int Year { get; set; }
        public string Name { get; set; }
         public string Author { get; set; }
        public Book()
        {
            Id = _LastId++;
        }







        public void AddBook()
        {
            Console.WriteLine("Хорошо, Введите название книги: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите год: ");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Имя автора?  ");
            Author = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"ID: {Id} | Название: {Name} | Автор: {Author}";
        }









    }
}
