using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST07
{
    internal class Circle
    {
        public double Radius;
        private string _color;

        public string Color { get; private set; } = "Red";
        public Circle()
        {
            Radius= 0;
            //_color= "Red";
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        private double CalculateArea()
        {
            return (3.14*Radius*Radius);
        }
         public void CircleDetails()
        {
            Console.WriteLine("Circle Details:");
            Console.WriteLine("Radius: "+Radius);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Area: "+CalculateArea());
        }
    }
}
