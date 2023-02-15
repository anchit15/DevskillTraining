using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST05
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Edition;
        public double Price;
        public string Genre;
        public string Language;


        public void Display()
        {
            Console.WriteLine("========Bok Details=========");
            if (Title != null)
            {
                Console.WriteLine("Title: "+Title);
            }
            if (Author != null)
            {
                Console.WriteLine("Author: " + Author);

            }
            if (Edition != 0)
            {
                Console.WriteLine("Edition: " + Edition);

            }
            if (Price != 0)
            {
                Console.WriteLine("Price(USD): " + Price);

            }
            if (Genre != null)
            {
                Console.WriteLine("Genre: " + Genre);

            }
            if (Language != null)
            {
                Console.WriteLine("Language: " + Language);

            }
            Console.WriteLine();

        }
    }
}
