using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    internal interface IBook
    {
         string BookCode { get; set; }
         string BookName { get; set; }
         string Author { get; set; }
         int Stock { get; set; }

        void AddBook();
        void Borrow(int quantity);
        void Return(int quantity);
        void Display();
    }
}
