using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student s1 = new Student();
            s1.Display();*/

            Console.Write("Enter Radius: ");
            Console.WriteLine();
            Circle c1 = new Circle(Convert.ToDouble(Console.ReadLine()));
            c1.CircleDetails();

            Console.ReadLine();
        }
    }
}
