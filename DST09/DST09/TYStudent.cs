using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST09
{
    internal class TYStudent : IHuman, IStudent
    {
        /*public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            throw new NotImplementedException();
        }*/
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IStudent.Roll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IStudent.GPA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("TY Display");
        }

        void IStudent.Display()
        {
            Console.WriteLine("TY IStudent Display");
        }
        //Specific implementation of methods is called explicit implementation
        void IHuman.Display()
        {
            Console.WriteLine("TY IHuman Display");
        }
    }
}
