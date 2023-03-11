using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InStepSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;                                                     //Обьявляем переменую string
            int A, B;                                                       //Обьявляем 2 переменные int
            Console.ForegroundColor = ConsoleColor.Yellow;                  //Красим консольку =)
            Console.WriteLine("Задача 3.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите число A - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                       //Вводим число А
            A = Convert.ToInt32(str);                                       //Конвертируем в целочисленый тип
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите число Б - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                       //Вводим число Б
            Console.ForegroundColor = ConsoleColor.Green;
            B = Convert.ToInt32(str);                                       //Конвертируем в целочисленый тип
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = A; i < B + 1; i++)                                 //Логика вывода пирамиды
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();                                              //Стоп консоли
        }
    }
}