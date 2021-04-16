using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите кол-во строк матрицы :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы :");
            m = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[n, m];
            double[] sum = new double[m];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next(0, 20);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i] += arr[j, i];
                }
            }
            foreach (double item in sum)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            double hold;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (sum[j + 1] > sum[j])
                    {
                        hold = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = hold;
                        for (int k = 0; k < n; k++)
                        {
                            hold = arr[k, j];
                            arr[k, j] = arr[k, j + 1];
                            arr[k, j + 1] = hold;
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var item in sum)
            {
                Console.Write(item + "\t");
            }
            Console.ReadKey();

        }
    }
}
