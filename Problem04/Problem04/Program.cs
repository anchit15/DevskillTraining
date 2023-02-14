using System;


namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int[,]sum = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==0)
                    {
                        if (j==0)
                        {
                            sum[i, j] = arr[i + 1, j] + arr[i, j + 1] + arr[i, j];
                            /*Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                        else if (j==n-1)
                        {
                            sum[i, j] = arr[i + 1, j] + arr[i, j - 1] + arr[i, j];
                           /* Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                        else
                        {
                            sum[i, j] = arr[i + 1, j] + arr[i, j + 1] + arr[i, j - 1] + arr[i, j];
                            /*Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                    }
                    else if (i==n-1)
                    {
                        if (j==0)
                        {
                            sum[i, j] = arr[i, j + 1] + arr[i - 1, j] + arr[i, j];
                            /*Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                        else if (j==n-1)
                        {
                            sum[i, j] = arr[i - 1, j] + arr[i, j - 1] + arr[i, j];
                            /*Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                        else
                        {
                            sum[i, j] = arr[i - 1, j] + arr[i, j - 1] + arr[i,j+1] + arr[i, j];
                            /*Console.WriteLine(sum[i, j]);
                            Console.ReadLine();*/
                        }
                    }
                    else if (i<n-1 && j==0)
                    {
                        sum[i, j] = arr[i + 1, j] + arr[i, j + 1] + arr[i - 1, j] + arr[i, j];
                        /*Console.WriteLine(sum[i, j]);
                        Console.ReadLine();*/
                    }
                    else if (i < n - 1 && j == n-1)
                    {
                        sum[i, j] = arr[i + 1, j] + arr[i, j - 1] + arr[i - 1, j] + arr[i, j];
                        /*Console.WriteLine(sum[i, j]);
                        Console.ReadLine();*/
                    }
                    else
                    {
                        sum[i, j] = arr[i - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, j + 1] + arr[i, j];
                        /*Console.WriteLine(sum[i, j]);
                        Console.ReadLine();*/
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sum[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int max = arr[0,0], row=0, col=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (sum[i, j] > max)
                    {
                        max = sum[i, j];
                        row=i; col=j;
                    }
                }
            }
            Console.WriteLine("Max Sum: " + max);
            Console.WriteLine("Index: " + row + ", " + col);
            Console.ReadLine();
        }
    }
}
