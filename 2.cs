using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер матрицы :");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            int sum = 0;
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(0, 20);
                    Console.Write(arr[i, j] + " " + '[' + (i) + ']' + '[' + (j) + ']' + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (i == j)
                    {
                        arr[i, i] = 0;
                        if (i != n - 1)
                            if (i + 1 > j)
                            {
                                arr[i + 1, j] = 0;

                            }
                        if (j != n - 1)
                            if (i < j + 1)
                            {
                                arr[i, j + 1] = 0;
                            }

                    }
                    sum += arr[i, j];
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов = " + sum);
        }
    }
}
