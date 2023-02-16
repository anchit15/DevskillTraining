using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Square : Rectangle
    {
        public Square()
        {
            
        }

        public Square(double side)
        {
            width= side;
            length= side;
        }
        public Square(double side, string color, bool filled) :base(side,side,color,filled)
        {
            //width = side;
            //length = side;
        }
        /*public double GetArea()
        {
            return width * width;
        }*/

       /* public double GetPerimeter()
        {
            return 4 * width;
        }*/
        /*public override void DisplayInfo()
        {
            //base.DisplayInfo();
            Console.WriteLine("Square Area: " + GetArea());
            Console.WriteLine("Square Perimeter: " + GetPerimeter());
        }*/
    }
}
