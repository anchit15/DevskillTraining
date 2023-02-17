using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST09
{
    internal class Student
    {
        /*public int a { get; set; }
        private int b { get; set; }
        protected int c { get; set; }
        internal int d { get; set; }*/

        public string Username { get; set; }
        public string Mobile { get; set; }

        public Course StudentCourse { get; set; }
        //public List<Course> StudentCourse { get; set; }       //For multiple courses


        public void Display()
        {
            Console.WriteLine("Username: " + Username);
            Console.WriteLine("Mobile: " + Mobile);
            Console.WriteLine("Course Name: " + StudentCourse.CourseName);
            Console.WriteLine("Course Fee: " + StudentCourse.CourseFee);
        }

    }
}
