using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1203
{
    internal class Course
    {
        public string CourseName { get; set; }
        public double CourseFee { get; set; }

        public Course(string name, double fee)
        {
            CourseName = name;
            CourseFee = fee;
        }
    }
}
