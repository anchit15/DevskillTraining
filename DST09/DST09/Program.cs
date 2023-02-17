using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
           // Human h= new SYStudent();

            /*IHuman th = new TYStudent();
            th.Display();*/

            Course c1= new Course();
            c1.CourseName = "C# Course";
            c1.CourseFee = 4000;

            Student s1 = new Student();
            s1.Username = "johnVai";
            s1.Mobile = "01794204313";
            s1.StudentCourse = c1;
            
            Student s2 = new Student();
            s2.Username = "totoBro";
            s2.Mobile = "01722336095";
            s2.StudentCourse = c1;
            s1.Display();
            Console.WriteLine("=======================================");
            s2.Display();


            Console.ReadLine();

            
            
        }
    }
}
