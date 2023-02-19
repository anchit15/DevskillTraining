using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST13
{
    internal sealed class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static string Universityname { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Age: "+ Age);
            Console.WriteLine("University: "+ Universityname);
        }
    }

    /*class B : Student
    {

    }*/

    class A
    {
        public virtual void Display()    //cannot be sealed unless the method is overriden
        {

        }
    }

    class B : A
    {
        public sealed override void Display()
        {
            
        }

    }

    class C: B
    {
        public /*override*/ void Display()      //Sealed method cannot be overriden
        {

        }
    }
}
