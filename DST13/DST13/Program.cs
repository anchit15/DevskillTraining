using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student.Universityname = "DIU";
            Student s1 = new Student();
            s1.Name = "John";
            s1.Age = 23;
            Student s2 = new Student();
            s2.Name = "Momin";
            s2.Age = 23;
            //s1.Universityname = "DIU";

            s1.Display();
            s2.Display();*/


            //Parameter Modifier:
            //out
            int a = 10;
            int b;
            int c;
            int d;
            Display(a, out b, out c, out d);
            Console.WriteLine(a + " " + b + " " + c + " " + d);

            //ref
            int e = 10;
            int f;
            int g=30;   //ref must be assigned, rest similar to out
            int h;
            Display2(e, out f, ref g, out h);
            Console.WriteLine(e + " " + f + " " + g + " " + h);

            //in
            int i = 10;
            int j;
            int k = 30;   //ref must be assigned, rest similar to out
            int l=40;
            Display3(i, out j, ref k, in l);
            Console.WriteLine(i + " " + j + " " + k + " " + l);

            //params
            int res = Add(10, 20);
            /*int[] arr = { 10, 20, 30 };
            int res = Add(arr);*/
            Console.WriteLine(res);

            Console.ReadLine();
        }

        static void Display(int x, out int y, out int z, out int p)
        {
            y = 20; z = 30; p = 40;
            Console.WriteLine(x+" "+y+" "+z+" "+p);
        }
        static void Display2(int x, out int y, ref int z, out int p)
        {
            y = 20; z = 30; p = 40;
            Console.WriteLine(x+" "+y+" "+z+" "+p);
        }
        static void Display3(int x, out int y, ref int z, in int p)
        {
            y = 20; z = 30; //p = 40;
            Console.WriteLine(x+" "+y+" "+z+" "+p);
        }

        static int Add(params int[] value)
        {
            int res = 0;
            foreach (var item in value)
            {
                res += item;
            }
            return res;
        }
    }
}
