using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST08
{
    internal class Student : Human
    {
        public int Roll { get; set; }

        public Student()
        {
            Console.WriteLine("Student CTOR");
        }

        public Student(int Roll, string name, int age) : base(name, age) //for when need to initialize private property of parent
        {
            Console.WriteLine("Student CTOR 02");
            this.Roll = Roll;
        }
    }
}
