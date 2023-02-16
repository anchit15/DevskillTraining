using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST06
{
    class Student
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Student(int Age)
        {
            this.Age = Age;
            Name = "John Doe";
            //Console.WriteLine("CTOR is called.");
        }
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        //public Student(string Name, int Age) => (this.Name, this.Age) = (Name, Age);

        /* public Student()        //ctor + tab tab
         {
             Age = 18;
             Name = "John Doe"; 
         }*/
        public Student() => (Age, Name) = (18, "John Doe");     //Same as the constructor above
        // public Student() => Age=18;  Shorthand

        public Student(string Name)
        {
            this.Name = Name;
            this.Age = 18;
        }

        ~Student()
        {
            Console.WriteLine("Destructor");

        }
        
        //~Student() => Console.WriteLine("Destructor called");
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }

        
        
    }
}
