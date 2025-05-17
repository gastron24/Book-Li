using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryBook 
{
   public class Book
    {
        private static int _LastId = 0;
        
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
         public string Author { get; set; }

        public Book()
        {
            Id = _LastId++;
        }
        public override string ToString()
        {
            return $"ID: {Id} | Название: {Name} | Автор: {Author} | Год: {Year}";
        }


        public void AddBook()
        {
            Console.WriteLine("Хорошо, Введите название книги: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите год: ");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Имя автора? : ");
            Author = Console.ReadLine();

            Id++;
            Console.WriteLine($"Книга {Name} добавленна. Ее можно найти по номеру[id] {Id}");
            
        }
        public void BookList()
        {
           
            List<object> listBooks = new List<object>()
            {
                
            };
        }
            
    }
}
