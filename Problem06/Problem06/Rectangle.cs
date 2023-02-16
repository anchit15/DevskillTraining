using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Rectangle : Shape
    {
        protected double width { get; set; }
        protected double length { get; set; }

        public Rectangle()
        {
            this.width = 2.0;
            this.length = 3.0;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;

        }

        public double GetArea()
        {
            return width*length;
        }
        public double GetPerimeter()
        {
            return 2*(width+length);
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Rectangle Area: " + GetArea());
            Console.WriteLine("Rectangle Perimeter: " + GetPerimeter());
        }

    }
}
