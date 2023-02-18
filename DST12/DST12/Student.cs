using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST12
{
    internal class Student
    {
        public string Name { get; set; }
        public int Roll { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Roll: "+Roll);
            Console.WriteLine("Salary: "+Salary);

        }
    }
}
