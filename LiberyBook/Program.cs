using LibraryBook;
using System.Runtime.InteropServices;

namespace LibraryBook;


class Program
{
   
   
    static void Main(string[] args)
    {

        
        Console.WriteLine("____________");
        Console.WriteLine("|Библиотека|");
        Console.WriteLine("------------");

        while (true)
        {
            UserMenu.Menu();

            int Choice = int.Parse(Console.ReadLine());

            switch(Choice)
            {
                case 1:
                    Book book = new Book();
                    book.AddBook();
                    BookLists bookLists = new BookLists();
                    bookLists.AddToList(book);

                    break;
                case 2:
                    BookLists ViewBook = new BookLists();
                    ViewBook.AllBook();
                    break;
                case 3:
                    BookLists RemoveBook = new BookLists();
                    RemoveBook.RemoveBook();
                    break;




            }






        }
        






    }
}
