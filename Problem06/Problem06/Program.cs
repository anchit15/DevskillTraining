using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape r1 = new Rectangle(2,3);

            Shape s1 = new Square(2);

            Shape cy1 = new Cylinder(3,2);

            Shape c1= new Circle(2);

            r1.DisplayInfo();
            Console.WriteLine();
            s1.DisplayInfo();
            Console.WriteLine();
            c1.DisplayInfo();
            Console.WriteLine();
            cy1.DisplayInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
