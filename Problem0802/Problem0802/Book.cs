using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem0802
{
    internal class Book
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Stock { get; private set; }

        public Book(string code, string name, string author, int stock)
        {
            this.Code= code;
            this.Name= name;
            this.Author= author;
            this.Stock= stock;
        }

        public void BorrowBook(int quantity)
        {
            Stock -= quantity;
        }
        public void ReturnBook(int quantity)
        {
            Stock += quantity;
        }
    }
}
