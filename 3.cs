using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер матрицы :");
            n = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[n, n];

            Random r = new Random();

            for (int i = 1; i < n; i++)
            {

                for (int j = 1; j < n; j++)
                {
                    arr[i, j] = 1.0 / Math.Pow(fuk(n), i);
                    Console.Write(arr[i, j] + " " + '[' + (i) + ']' + '[' + (j) + ']');
                }
                Console.WriteLine();
            }
            Console.WriteLine();




        }
        static double fuk(double n)
        {
            double a = 1;
            for (int i = 1; i < n; i++)
            {
                a *= i;
            }
            return a;
        }
    }
}
