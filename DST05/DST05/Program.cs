using System;


namespace DST05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student s1= new Student();
            s1.Name= "John";
            s1.Age= 23;
            s1.Cgpa = 3.92;
            s1.Display();
            Console.ReadLine();

            Student s2 = new Student();
            s2.Name = "Toto";
            s2.Age = 24;
            s2.Cgpa = 3.85;
            s2.Display();
            Console.ReadLine();

            Book b1= new Book();
            Book b2= new Book();

            b1.Title = "The Lord Of The Rings: The Fellowship Of The Ring";
            b1.Author = "J R.R. Tolkein";
            b1.Edition = 10;
            b1.Price = 23.99;
            b1.Genre = "Fantasy";
            b1.Language = "English of some sort";

            b2.Title = "Nemesis";
            b2.Author = "Md. Nazim Uddin";
            b2.Edition = 1;
            b2.Price = 15.99;
            b2.Genre = "Thriller";
            b2.Language = "Bengali";

            b1.Display();
            b2.Display();*/

            BankAccount b = new BankAccount();
            b.AccountName = "John";
            b.AccountNumber = "123-456-789";
            //b.SetAccountBalance(500);
            //b.SetAccountBalance(500);

            //Console.WriteLine(b.GetAccountBalance());

            Console.ReadLine();
        }
    }
}
