using System;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n,n];

            /*foreach(var item in arr)
            {
                foreach (var i in item)
                {
                    Convert.ToInt32(Console.ReadLine());
                }
            }*/

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i,j]+"  ");
                }
                Console.WriteLine();
            }

            int sum1 = 0, sum2=0;
            for (int i = 0; i < n; i++)
            {
                sum1 += arr[i,i];
            }
            int k = 0;
            for (int i = n-1; i >= 0; i--)
            {
                sum2 += arr[i, k];
                //Console.WriteLine(sum2);
                k++;
            }

            Console.WriteLine("Regular Diagonal: "+ sum1);
            Console.WriteLine("Reverse Diagonal: " + sum2);
            Console.ReadLine();

        }
    }
}
