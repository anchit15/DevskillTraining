using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST0702
{
    internal class Student : Human
    {
        
        public double GPA { get; set; }

        public Student()
        {
            Console.WriteLine("Student CTOR");

        }
        public void DisplayStudent()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("GPA: " + GPA);
        }
    }
}
