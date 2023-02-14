using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, i, m = 0, flag = 0;
            Console.Write("Give a number: ");
            p = int.Parse(Console.ReadLine());
            n = ReverseInt(p);
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    //Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(n+"(Prime)");
            //Console.ReadLine();
        }
        static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}