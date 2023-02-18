using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1002
{
    internal class Student : Human
    {
        public override void Display()
        {
            Console.WriteLine("Student Display");
        }
        public void Display(int a)
        {
            Console.WriteLine("Student Display with int");
        }
        public void Display(double a)
        {
            Console.WriteLine("Student Display with double");
        }
    }
}
