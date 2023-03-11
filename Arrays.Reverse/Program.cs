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
            string str;                                                     //Обьявляем переменые string
            Console.ForegroundColor = ConsoleColor.Yellow;                  //Красим консольку =)
            Console.WriteLine("Задача 4.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите число N - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                       //Вводим число N
            char[] array = str.ToCharArray();                               //Обьявляем Char массив
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Array.Reverse(array);                                           //Преворачиваем массив наоборот
            Console.Write(array);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();                                              //Стоп консоли
        }
    }
}