using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem0802
{
    internal interface ILibraryModel
    {
        void AddBook();
        void ReturnBook();
        void BorrowBook();
        void DisplayBook();
    }
}
