using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST07
{
    internal class Student
    {
        public int? Age { get; set; } = 18;
        //public readonly int Age = 10;
        //public const int age = 10;    //public int Age => 10

        public Student()
        {
            Age = 20;
        }
        public void Display()
        {
            Console.WriteLine("Age: "+Age);
        }
    }
}
