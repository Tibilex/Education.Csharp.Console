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
            const int M = 10, N = 10;
            int[] arrA = new int[M];
            int[] arrB = new int[N];
            int[] arrC = new int[N];
            int repeat = 0, index = 0;

            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                arrA[i] = rand.Next(1, 20);
                arrB[i] = rand.Next(1, 20);
            }

            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == arrB[j])
                    {
                        for (int k = 0; k < arrC.Length; k++)
                        {
                            if (arrC[k] == arrB[j])
                                repeat++;
                        }
                        if (repeat == 0)
                        {
                            arrC[index] = arrB[j];
                            index++;
                        }
                        repeat = 0;
                    }
                }
            }
            Console.WriteLine("Массив A", Console.ForegroundColor = ConsoleColor.Yellow);
            foreach (int i in arrA)
                Console.Write($" {i} ");
            Console.WriteLine();
            Console.WriteLine("Массив B");
            foreach (int i in arrB)
                Console.Write($" {i} ");
            Console.WriteLine();
            Console.WriteLine("Массив C");
            foreach (int i in arrC)
                Console.Write($" {i} ");
            Console.WriteLine();
        }
    }
}
