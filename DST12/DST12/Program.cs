using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student s1 = new Student();
            s1.Name = "John";
            s1.Roll = 101;

            Student s2 = new Student();
            s2.Name = "Toto";
            s2.Roll = 102;

            var studentList = new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);

            foreach (var item in studentList)
            {
                item.Display();
            }*/

            var studentList = new List<Student>()
            {
                new Student(){ Name="John", Roll=101, Salary = 10000},
                new Student(){ Name="Toto", Roll=102, Salary = 400000}
            };

            var myStudentList = from s in studentList
                                where s.Roll >= 101 
                                && s.Name.StartsWith("J")
                                select s;

            var myStudentList2 = studentList.Where(s => s.Roll >= 102 && s.Name.StartsWith("T")).ToList();   //Method syntax of the above code
                                                    //The part inside where is called Lambda Expression

            var totalSalary = studentList.Sum(s => s.Salary);
            Console.WriteLine("Total Salary: " + totalSalary);

            totalSalary = studentList.Where(x=>x.Salary>100000).Sum(x=>x.Salary);

            foreach (var item in myStudentList)
            {
                item.Display();
            }
            foreach (var item in studentList.OrderByDescending(x=>x.Roll))
            {
                item.Display();
            }


            /*var a = new List<int>();
            a.Add(10);
            a.Add(20);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadLine();
        }
    }
}
