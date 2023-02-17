using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST09
{
    internal abstract class Human
    {
        public string name { get; set; }
        public abstract string Age { get; set; }
        public abstract void Display();
        
    }
}
