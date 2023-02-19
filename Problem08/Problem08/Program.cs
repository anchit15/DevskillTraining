using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new List<IBook>();
            
            Console.WriteLine("Welcome TO ABC Library System");
            while (true)
            {
                Console.WriteLine("Please Select an Option: ");
                Console.WriteLine("1: Add Book");
                Console.WriteLine("2: Borrow Book");
                Console.WriteLine("3: Return Book");
                Console.WriteLine("4: Display List");
                Console.WriteLine("5: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IBook b1 = new Book();
                        b1.AddBook();
                        
                        if (b.Any(x=>x.BookCode==b1.BookCode))
                        {
                            Console.WriteLine("Sorry. Book already exists");
                           // b.Remove(b1);
                        }
                        else
                        {
                            b.Add(b1);
                            Console.WriteLine("Book Successfully Added to Library");
                        }


                        break;
                    case 2:
                        Console.Write("Book Code: ");
                        string code = Console.ReadLine();
                        Console.Write("Borrow Book Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        var myBook = from n in b
                                     where n.BookCode==code
                                     select n;
                        foreach (var item in myBook)
                        {
                            item.Borrow(quantity);
                        }
                        break;
                    case 3:
                        Console.Write("Book Code: ");
                        string returnCode= Console.ReadLine();
                        Console.Write("Return Book Quantity: ");
                        int returnQuantity = Convert.ToInt32(Console.ReadLine());
                        var myReturnBook = b.Where(x=> x.BookCode==returnCode);
                        foreach (var item in myReturnBook)
                        {
                            item.Return(returnQuantity);
                        }
                        break;
                    case 4:
                        foreach (var item in b)
                        {
                            item.Display();
                        }
                        break;

                    default:
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
            }
            Console.WriteLine("Thank you for using ABC Library Sysem");
            Console.ReadLine();
            
        }
    }
}
