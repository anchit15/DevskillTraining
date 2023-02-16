using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST0702
{
    internal class JobHolder : Human
    {
        
        public double Salary { get; set; }

        public JobHolder()
        {
            Console.WriteLine("JobHolder CTOR");

        }
        /*public new void Display()
        {
            Console.WriteLine("JobHolder Name: " + Name);
            Console.WriteLine("JobHolder Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
        }*/
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class PvtJobHolder : JobHolder
    {
        public PvtJobHolder()
        {
            Console.WriteLine("Private JobHolder CTOR");
        }
    }
}
