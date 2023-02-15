using System;


namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h= new Human();
            h.Name=Console.ReadLine();
            Console.WriteLine("Name: "+h.Display());
            Console.ReadLine();
        }
    }
}
