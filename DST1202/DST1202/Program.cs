using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST1202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            string[] names = { "John", "Anchit", "Kheali", "Gomes" };
            
            var myQuery = from n in names
                          where n.StartsWith("J")   //works kinda like query
                          select n;                 //select * from n where....you get the idea

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
