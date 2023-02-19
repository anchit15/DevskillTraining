using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST14
{
    internal class Program
    {
        static bool IsUpper(string s)
        {
            return s.Equals(s.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Delegate");
            Console.WriteLine("==================");
            Calculator c1 = new Calculator();
            c1.Sum(10, 15);

            Calculator.myDelegate s1 = c1.Sum; //s1 is an object of delegate type

            //s1.Invoke(10,20);    //Will work without invoke. Invoke is more readable
            s1 += c1.Sub;

            s1 += c1.Sub;
            //s1.Invoke(10, 20);
            s1 += c1.Multi;

            s1 -= c1.Sub;
            
            s1.Invoke(10, 20);  //calls all methods that are subscribed

            Console.WriteLine("==================");
            Console.WriteLine("Event");
            Console.WriteLine("==================");

            Transaction t1 = new Transaction();
            t1.WithdrawTransaction(5000);


            Console.WriteLine("==================");
            Console.WriteLine("Action Delegate");
            Console.WriteLine("==================");

            Calculator2 c2= new Calculator2();
            Action<int, int> s2 = c2.Sum;   //Not required to use delegate in calcu class anymore

            s2 += c2.Sub;
            s2 += c2.Sub;
            s2 += c2.Multi;
            s2 -= c2.Sub;

            s2.Invoke(100, 150);

            Console.WriteLine("==================");
            Console.WriteLine("Func Delegate");
            Console.WriteLine("==================");

            Func<int, int, bool> s3 = c2.Sum2;     //Action must be void. Func cannot be void, must have return type
            //Last type is for return type
            s3.Invoke(100, 200);


            Console.WriteLine("==================");
            Console.WriteLine("Predicate Delegate");
            Console.WriteLine("==================");

            Predicate<string> p = IsUpper;
            bool result = IsUpper("John Anchit");
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
