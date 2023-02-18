using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Student().Display(5);

            Human h = new Student();
            h.Display();

            Console.ReadLine();
        }
    }
}
