using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1202
{
    internal class Student
    {
        public string Name { get; set; }
        public int Roll { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll: " + Roll);

        }
    }
}
