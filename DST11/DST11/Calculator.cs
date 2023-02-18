using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST11
{
    interface ICalculator
    {
        void Display();
    }
    //internal class Calculator<T, U>    //Generic. any name, T mostly used

    //{
    /*public int Sum(int a, int b)
    {
        return a + b;
    }
    public double Sum(double a, double b)
    {
        return a + b;
    }
    public string Sum(string a, string b)
    {
        return a + b;
    }*/

    /* public T First { get; set; }
     public U Second { get; set; }
     //public dynamic First { get; set; }
     //public dynamic Second { get; set; }

     public Calculator(T first, U second)
     {
         this.First = first;
         this.Second = second;
         //this.First = 10;    //This cannot be done. Not able to forcefully convert to int and etc.

     }

     public U Sum()
     {
         dynamic d1 = First;     //any data type is adapted through dynamic
         dynamic d2 = Second;
         return d1 + d2;

     }*/

    /*public U Sum ()
    {

        return First + Second;
    }*/
    //}

    internal class Calculator <T> : ICalculator where T : Human      //It means T must be Human
    {
        public Human human { get; set; }

        public Calculator(T a)
        {
            human = a;  
        }
        public void Display()
        {
            Console.WriteLine("Age is: "+human.Age);
        }
    }
}
