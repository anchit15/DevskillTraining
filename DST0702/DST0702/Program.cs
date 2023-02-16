using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST0702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Human h1 = new Human();
            h1.Name = "John";
            h1.Age = 23;
            h1.DisplayHuman();*/

            /*JobHolder j1 = new JobHolder();
            j1.Name = "John";
            j1.Age = 23;
            j1.Salary = 1500;
            j1.DisplayHuman();*/

            Human j1 = new PvtJobHolder();
            //PvtJobHolder j1 = new PvtJobHolder();
            j1.Name = "John";
            j1.Age = 23;
            //j1.Salary = 1500;
            j1.Display();

            
            Console.ReadLine();
        }
    }
}
