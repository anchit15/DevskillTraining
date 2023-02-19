using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST14
{
    internal class Calculator
    {

        public delegate void myDelegate(int p, int q);
        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum is: "+ (x+y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction is: " + (x-y));
        }
        public void Multi(int x, int y)
        {
            Console.WriteLine("Multiplication is: " + (x*y));
        }

        public void test()
        {
            Console.WriteLine("Will it give exception?");
            //gives error in the code. Smart

        }


    }
}
