using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST0702
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human()
        {
            Console.WriteLine("Human CTOR");
        }
        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
