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
            int BankAccount = 10000;                                                                            //Банковский счет 
            int Percent, Mounth = 0;                                                                            //Процент и месяц 'Р' и 'К' по условию
            string str;

            Console.Write("Введите процент % - ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.Blue;
            str = Console.ReadLine();
            Percent = Convert.ToInt32(str);                                                                     //Конвертация в int
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; ; i++)                                                                              //Основная логика
            {
                if (Percent <= 0)                                                                               //Если процент 0 выход из программы
                {
                    Console.WriteLine("\nПроцент не может быть 0", Console.ForegroundColor = ConsoleColor.Red); //Некоректный ввод
                    break;
                }
                else
                {
                    if (BankAccount >= 11000)                                                                   //Если счет выше 11000 Вывод данных в консоль
                    {
                        Console.Write("Сумма превысила 11000\n" + "Текущая сумма = ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(BankAccount);
                        Console.Write("Количество месяцев = ", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Mounth);
                        break;
                    }
                    else
                    {
                        BankAccount = BankAccount * (100 + Percent) / 100;                                      //Считаем процент и присваеваем числу
                        Mounth += i;                                                                            //Счетчик месяцев
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();                                                                                  //Стоп консоли
        }
    }
}