using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1002
{
    partial class A
    {
        public string Name { get; set; }
    }

    /*internal class A
    {
        //Not Possible under one namespace
    }*/

    partial class A
    {
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine("Name");      //Beneficiary when 2 developers working at the same class

        }
    }
}
