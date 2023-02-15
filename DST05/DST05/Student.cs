using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST05
{
    internal class Student
    {
        public string Name;
        public int Age;     //Member Variables
        public double Cgpa;


        public void ResultCalculation()
        {
                    //Method
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);       //Method
            Console.WriteLine("Cgpa: " + Cgpa);

        }
    }
}
