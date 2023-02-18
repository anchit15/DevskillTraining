using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1002
{
    internal class Human
    {
        public virtual void Display()
        {
            Console.WriteLine("Human Display");
        }
        public void Display(int a)
        {
            Console.WriteLine("Human Display with int");
        }
        public void Display(double a)
        {
            Console.WriteLine("Human Display with double");
        }
    }
}
