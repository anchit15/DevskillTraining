using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem0802
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC Library");

            var bookList = new List<Book>();

            ILibraryModel libraryModel = new LibraryModel(bookList);

            while (true)
            {
                OptionMessage();
                Console.Write("Choose option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                if(option == 1)
                {
                    libraryModel.AddBook();
                }
                else if (option == 2)
                {
                    libraryModel.BorrowBook();
                }
                else if (option == 3)
                {
                    libraryModel.ReturnBook();
                }
                else if (option == 4)
                {
                    libraryModel.DisplayBook();
                }
                else 
                {
                    break;
                }


            }
        }

        public static void OptionMessage()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Retuen Book");
            Console.WriteLine("4. Display List");
            Console.WriteLine("5. Exit");
        }
    }
}
