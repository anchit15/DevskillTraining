using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DST14
{
    internal class Calculator2
    {

        public void Sum(int p, int q)
        {
            Console.WriteLine("Calcu 2 Sum: " + (p + q));
        }

        public bool Sum2(int p, int q)
        {
            Console.WriteLine("Calcu 2 Sum: " + (p + q));
            return true;
        }
        public void Sub(int p, int q)
        {
            Console.WriteLine("Calcu 2 Sub: " + (p - q));
        }
        public void Multi(int p, int q)
        {
            Console.WriteLine("Calcu 2 Multi: " + (p * q));
        }
    }
}
