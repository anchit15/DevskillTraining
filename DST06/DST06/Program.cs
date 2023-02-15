using System;


namespace DST06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("John",23);
            Student s2 = new Student();
            Student s3 = new Student("Toto");

            //s1.Name = "John";
            s1.Display();
            Console.WriteLine();
            s2.Display();
            Console.WriteLine();
            s3.Display();
            Console.WriteLine();

            Close();
            GC.Collect();       //GC used to call Destructor


            Console.ReadLine();
        }

        static void Close()
        {
            Student S4 = new Student(20);
            S4.Display();
        }
    }
}
