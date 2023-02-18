using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DST11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calculator<int, double> c1= new Calculator<int, double>(5,8.5);
            var c2= new Calculator<double, double>(5.5, 9.8);       //works all the same
            var c3= new Calculator<string, string>("John", "Vai");
            Console.WriteLine("Sum = "+c1.Sum());
            Console.WriteLine("Sum = "+c2.Sum());
            Console.WriteLine("String adding = " + c3.Sum());*/

            Human human= new Human();
            human.Age= 18;
            var c1 = new Calculator<Human>(human);


            Console.ReadLine();
        }
    }
}
