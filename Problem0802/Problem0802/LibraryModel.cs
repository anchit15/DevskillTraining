using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleTables;

namespace Problem0802
{
    internal class LibraryModel : ILibraryModel
    {
        private List<Book> bookList;

        public LibraryModel(List<Book> bookList)
        {
            this.bookList = bookList;
        }
        public void AddBook()
        {
            Console.Write("Book Code: ");
            string code = Console.ReadLine();
            Console.Write("Book Name: ");
            string name = Console.ReadLine();           
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Initial Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Book b = new Book(code,name, author, quantity);
            bookList.Add(b);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Book Added Successfully");
            Console.ResetColor();
        }

        public void BorrowBook()
        {
            Console.Write("Book Code: ");
            string borrowCode = Console.ReadLine();

            Book searchBook = bookList.Where(x=> x.Code == borrowCode).FirstOrDefault();
            if(searchBook != null)
            {
                Console.Write("Enter Book Stock: ");
                int borrowStock = Convert.ToInt32(Console.ReadLine());
                if(searchBook.Stock>=borrowStock)
                {
                    searchBook.BorrowBook(borrowStock);
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Successfully Borrowed");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Book Not Found");
                }
            }
        }
        
        public void DisplayBook()
        {
            /*var tb = new ("Code", "Name", "Author", "Stock");
            foreach(var item in bookList)
            {
                table.Rows.Add(item.Code, item.Name, item.Author, item.Stock);
            }
            table.Write();*/
        }

        public void ReturnBook()
        {
            Console.Write("Book Code: ");
            string returnCode = Console.ReadLine();

            Book searchBook = bookList.Where(x => x.Code == returnCode).FirstOrDefault();
            if (searchBook != null)
            {
                Console.Write("Enter Return Quantity: ");
                int returnStock = Convert.ToInt32(Console.ReadLine());
               
                searchBook.ReturnBook(returnStock);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully Returned");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
        }
    }
}
