using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Circle : Shape
    {
        protected double Radius { get; set; }

        public Circle()
        {
            this.Radius = 2.0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.Radius = radius;
        }

        public virtual double GetArea()
        {
            return Math.PI*Radius*Radius;
        }
        public double GetPerimeter()
        {
            return Math.PI*2*Radius;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Circle Area: {0:0.##}" ,GetArea());
            Console.WriteLine("Circle Perimeter: " + GetPerimeter());
        }

    }
}
