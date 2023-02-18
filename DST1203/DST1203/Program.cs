using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>()
            {
                new Student(){ Name="John", Roll=101, Salary = 10000},
                new Student(){ Name="Toto", Roll=102, Salary = 400000}
            };

            List<Student> myStudentList = studentList.Where(x => x.Salary>5000).ToList();
            Student myStudent = studentList.Where(x => x.Salary>5000).FirstOrDefault();     //For getting a single object.
                                                                                            //First(), Single(), FirstOrDefault(), SingleOrDefault()
            //myStudent.Display();

            //First() throws an exception when above where returns null
            //FirstOrDefault() does not throw exception

            Student myStudent2 = studentList.Where(x => x.Salary > 10000).SingleOrDefault();

            //When this'll thow Exception:
            //First() = No element
            //FirstOrDefault() = No Exception
            //Single() = No element, more than 1 element
            //SingleOrDefault() = More than 1 element

            
            Course c1 = new Course("C#", 4000);
            Course c2 = new Course("ASP.Net", 12000);
            Course c3 = new Course("PHP", 15000);

            var courseList = new List<Course>();
            courseList.Add(c1);
            courseList.Add(c2);
            courseList.Add(c3);

            var courseList1 = new List<Course>();
            courseList1.Add(c1);
            courseList1.Add(c2);
            

            var studentList3 = new List<Student>()
            {
                new Student(){ Name="John", Roll=101, Salary = 10000, SelectedCourseList = courseList},     //Multiple Course
                new Student(){ Name="Toto", Roll=102, Salary = 400000, SelectedCourseList = courseList1}     //c1 if single course
            };
            foreach (var item in studentList3)
            {
                item.Display();
            }

            Console.ReadLine();
        }
    }
}
