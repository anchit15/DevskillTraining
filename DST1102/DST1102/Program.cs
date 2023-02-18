using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList a= new ArrayList();   //var a = new ArrayList()
            IList a = new ArrayList();
            a.Add(10);
            a.Add(20);
            a.Add(30.5);
            a.Add("John");  //Any type of data can be stored

            a.Insert(1, "Toto");    //Index, value. Does not replace, simply puts it in between
            a.Insert(1, "Bro");

            a.Remove(20);   //Takes value as parameter. If multiple 20, then the one with smaller index
            a.RemoveAt(2);  //Takes index as parameter

            Console.WriteLine("======ArrayList======");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


            var b = new Hashtable();

            Console.WriteLine("======HashTable======");
            b.Add("Toto", 24);
            b.Add("John", 23);
            //b.Add("Toto", 24);
            foreach (var item in b.Keys)
            {
                Console.Write(item+": ");
                Console.WriteLine(b[item]);
            }
            Console.WriteLine("======SortedList======");
            var c = new SortedList();
            c.Add("Toto", 24);
            c.Add("John", 23);

            foreach (var item in c.Keys)
            {
                Console.Write(item+": ");
                Console.WriteLine(c[item]);
            }


            //Generic Collections: 
            var d = new List<int>();        //Restricted to only integer types

            var e = new HashSet<int>();     //Hashset only takes unique values

            var f = new Dictionary<int, string>();  //Key cannot be duplicate

            var g = new SortedList<int, string>();

            var h = new LinkedList<int>();

            

            Console.ReadLine();
        }
    }
}
