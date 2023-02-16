using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Cylinder : Circle
    {
        private double Height { get; set; }
        public Cylinder()
        {
            this.Height = 2.0;
        }
        public Cylinder(double height)
        {
            this.Height = height;
        }
        public Cylinder(double height, double radius) : base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double height, double radius, string color, bool filled) : base(radius, color, filled)
        {
            this.Height= height;
        }

        public override double GetArea()
        {
            return 2*Math.PI*Radius*(Height+Radius);
        }
        /*public double GetPerimeter()
        {
            return base.GetPerimeter();
        }*/

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            //Console.WriteLine("Cylinder Area: " + GetArea());
            //Console.WriteLine("Cylinder Perimeter: " + GetPerimeter());
        }
    }
}
