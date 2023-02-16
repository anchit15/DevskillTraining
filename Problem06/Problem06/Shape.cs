using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    internal class Shape
    {
        private string Color;
        private bool IsFilled;

        public Shape()
        {
            Color = "Red";
            IsFilled = true;
        }

        public Shape(string color, bool filled)
        {
            Color = color;
            IsFilled = filled;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Filled?: "+IsFilled);
        }
    }
}
