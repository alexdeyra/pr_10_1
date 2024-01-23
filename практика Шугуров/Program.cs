using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_Шугуров
{
    class Program
    {
        static void Main (string[] args)
        {
            //9
            const int n = 4;
            int[,] a = new int[n, n];
            int k = 0;
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(10) - 5;
                    Console.Write($"{a[i, j]} ");
                    if (j == i && a[i, j] == 0)
                    {
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Нулей нету");
                    }
                    if (j == n - i - 1)
                    {
                        count += a[i, j] % 2;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Кол-во нулей на главной диагонали: {k}");
            Console.WriteLine("Числа нечетных элементов:" + count);

            //7
            //const int n = 5;
            //const int m = 7;
            //int[,] a = new int[n, m];
            //int cnt = 0;
            //int s = 0;
            //int k = 0;
            //int sr = 0;
            //Random rand = new Random();
            //for (int i=0; i<n; i++)
            //{
            //    for (int j=0; j<m; j++)
            //    {
            //        a[i, j] = rand.Next(20);
            //        Console.Write($"{a[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i=0; i<n; i++)
            //{
            //    if (a[i,1] > 15)
            //    {
            //        cnt++;
            //    }
            //}
            //for (int i=4; i<5;i++)
            //{
            //    for (int j = 0; j<5; j++)
            //    {
            //        if (a[i,j]%2 !=0)
            //        {
            //            s += a[i, j];
            //        }
            //    }
            //}
            //double cr = (double) s / a[4, 0];
            //for (int i=0; i<n;i++)
            //{
            //    if (a[i,3]%4==0)
            //    {
            //        k++;
            //        sr += a[i, 3];
            //    }
            //}
            //if (k==0)
            //{
            //    Console.WriteLine("В четвёртом столбце нет элементов, кратных 4");
            //}
            //else
            //{
            //    sr /= k;
            //    Console.WriteLine("Среднее арифметичесое элементов четвёртого столбца, кратных 4=" + sr.ToString("0.00"));
            //}
            //Console.WriteLine($"кол-во ненулевых элементов второго стобца массива, больше 15: {cnt}");
            //Console.WriteLine($"{cr,5:F3}");
            Console.ReadKey();
        }
    }
}
