using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBook;
namespace LibraryBook
{
    class BookLists
    {
        private static List<Book> Books = new List<Book>();
            
        public void AddToList(Book book)     
        {
            Books.Add(book);
            Console.WriteLine($"Книга {book.Name} Успешно добавленна, Id: {book.Id} ");
        }
       
        public void RemoveBook()
        {
            Console.WriteLine("---Удаление книги---");
            Console.WriteLine("---Выберите Id Книги для Удаления---");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Book bookToRemove = Books.Find(b => b.Id == id);

                if (bookToRemove != null)
                {
                    Books.Remove(bookToRemove);
                    Console.WriteLine("Книга успешно удалена!");
                }
                else
                {
                    Console.WriteLine("Книга с таким ID не найдена!");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод ID!");
            }
        }
            
        
        
        public void AllBook()
        {
            Console.WriteLine("\n[Список литературы]");
            Console.WriteLine("-------------------");

            if (Books.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }

            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-------------------");



        }


    }
}
