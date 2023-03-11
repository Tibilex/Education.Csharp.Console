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
            string str;
            int A, B, C, Sum = 0;
            double horizontal, Vertical;

            Console.WriteLine("Задача 1.\n", Console.ForegroundColor = ConsoleColor.Yellow);                    //Красим Всё =)
            Console.Write("Введите размер прямоугольника", Console.ForegroundColor = ConsoleColor.Green);
            Console.Write("\nВведите Сторону A - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                                                           //Вводим сторону А
            A = Convert.ToInt32(str);                                                                           //Конвертируем в int
            Console.Write("Введите Сторону Б - ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                                                           //Вводим сторону Б
            B = Convert.ToInt32(str);                                                                           //Конвертируем в int
            Console.Write("\nВведите Сторону квадрата С - ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();                                                                           //Вводим сторону квадрата С
            C = Convert.ToInt32(str);                                                                           //Конвертируем в int
            Console.WriteLine();
            if (A % C == 0 && B % C == 0)                                                                       //Проверка Площади Прямоугольника
            {
                horizontal = A / C;                                                                             //Узнаем количество квадратов в горизонатльном ряду
                Vertical = B / C;                                                                               //Узнаем количество квадратов в вертикальном ряду
                Sum = (int)horizontal * (int)Vertical;                                                          //Сумма всех квадратов на всю площадь
                Console.Write("Количество вписаных квадратов = ", Console.ForegroundColor = ConsoleColor.Green);//Вывод в консоль результатов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Sum);
            }
            else
            {                                                                                                   //Таже логика что и в блоке выше, разница в обрезании остатка от деления
                horizontal = A / C;
                Vertical = B / C;
                Math.Truncate(horizontal);                                                                      //Режем остаток от деления и округляем в сторону 0
                Math.Truncate(Vertical);
                Sum = (int)horizontal * (int)Vertical;                                                          //Явно приводим тип double в int
                Console.Write("Количество вписаных квадратов = ", Console.ForegroundColor = ConsoleColor.Green);//Вывод в консоль результатов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Sum);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();                                                                                  //Стоп консоли
        }
    }
}