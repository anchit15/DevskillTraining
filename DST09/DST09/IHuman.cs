using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST09
{
    internal interface IHuman
    {
        string Name { get; set; }
        string Age { get; set; }

        void Display();
    }


    internal interface IStudent
    {
        string Roll { get; set; }
        string GPA { get; set; }

        void Display();
    }
}
