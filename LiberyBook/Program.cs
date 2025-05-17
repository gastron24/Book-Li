using LibraryBook;
using System.Runtime.InteropServices;

namespace LibraryBook;


class Program
{
   
    static void Main(string[] args)
    {
        Program program = new Program();
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
                     

                    break;
                




            }






        }
        






    }
}
