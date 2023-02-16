using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST08
{
    internal class Human
    {
        private int Age { get; set; }

        private string Name { get; set; }

        public Human()
        {
            Console.WriteLine("Human CTOR");
        }
        public Human(string Name, int Age)
        {
            Console.WriteLine("Human CTOR 02");
            this.Name = Name;
            this.Age = Age;
        }
    }
}
