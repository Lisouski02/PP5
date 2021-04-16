using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер матрицы :");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(0, 20);
                    Console.Write(arr[i, j] + " " + '[' + (i) + ']' + '[' + (j) + ']' + ' ');
                }
                Console.WriteLine();
            }

            arr[5, 5] = 0;
            arr[0, 0] = 0;
            Console.WriteLine();
            //вывод главной диагонали
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (i == j)
                    {
                        Console.WriteLine(arr[i, i]);

                    }


                }

            }

            //поиск максимального 
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {


                if (arr[i, i] == 0)
                {
                    Console.WriteLine("Номер глвной диагонали элемент которой = 0 :" + i);

                    int max = arr[i, i];
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];

                        }
                    }
                    Console.WriteLine("Значение наибольшего элемента в строгегде элемент главной диаогнали = 0:" + max);

                }

            }
        }
    }
}
