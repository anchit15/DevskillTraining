using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    internal class Book : IBook
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }

        public void AddBook()
        {
            Console.Write("Book Code: ");
            BookCode= Console.ReadLine();
            Console.Write("Book Name: ");
            BookName = Console.ReadLine();
            Console.Write("Author Name: ");
            Author = Console.ReadLine();
            Console.Write("Initial Stock: ");
            Stock = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Borrow(int quantity)
        {
            if (quantity > Stock)
            {
                Console.WriteLine("Sorry. Given quantity not available");
            }
            else
            {
                Stock-=quantity;
                Console.WriteLine("Successfully Book Borrowed from Library");
            }
            
        }
        public void Return(int quantity)
        {
            Stock+=quantity;
            Console.WriteLine("Successfully Book Returned to Library");
        }

        public void Display()
        {
            Console.WriteLine("Code     Name    Author    Remaining Stock");
            Console.WriteLine("=================================================");
            Console.WriteLine(BookCode + "     " + BookName + "     " + Author + "     " + Stock);

        }
    }
}
