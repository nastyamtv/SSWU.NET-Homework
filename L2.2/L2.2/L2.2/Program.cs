using System;

namespace L2._2
{
    class Matrix 
    {
        public int n;
        public int m;

        public int[,] VerticalSnake() 
        {
            int[,] arr = new int[n,m];
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                { 
                    arr[i,j]=0;
                }
            }
            int k = 1;
            for (int j = 0; j < m; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        arr[i, j] = k;
                        k++;
                    }
                }
                if (j % 2 == 1) 
                {
                    for (int i = n-1; i >=0; i--)
                    {
                        arr[i, j] = k;
                        k++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }

            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Matrix Array = new Matrix();
            Array.n = 3;
            Array.m = 4;
            Array.VerticalSnake();
        }
    }
}
