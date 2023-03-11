using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        static void Main()
        {
            int[,] arr = new int[5, 5];

            Console.WriteLine("Вся матрица 5х5\n", Console.ForegroundColor = ConsoleColor.Yellow);
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write($" {arr[i, j]}\t");
                }
                Console.WriteLine();
            }

            bool CheckSum = false;
            int MaxI = 0, MinI = 0, MaxJ = 0, MinJ = 0, Sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == MinI && j == MinJ) || (i == MaxI && j == MaxJ))
                    {
                        CheckSum = !CheckSum;
                        continue;
                    }

                    if (CheckSum)
                        Sum += arr[i, j];
                }
            Console.WriteLine("\nВывод суммы между Min и Max элементами - " + Sum + "\n");
        }
    }
}

