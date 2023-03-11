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
            double[] arr = new double[5];                                           //Одномерный массив
            double[,] arr2 = new double[3, 4];                                      //Двумерный массив

            Console.WriteLine("Введите 5 чисел для заполнения массива",
                Console.ForegroundColor = ConsoleColor.Yellow);
            string value;
            int counter = 5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Осталось ввести - " + counter);
                counter--;
                value = Console.ReadLine();                                         //Заполняем массив с клавиатуры
                arr[i] = Convert.ToDouble(value);                                   //Конвертируем и записываем в массив 
            }
            double Sum = arr[0], even = 0;
            for (int i = 0; i != arr.Length; i++)
            {
                Sum *= arr[i];                                                      //Произведение элементов
                if (arr[i] % 2 == 0)                                                //Проверка на четность
                    even += arr[i];                                                 //Сумма четных элементов
            }

            Console.Clear();                                                        //Чистим консоль

            Console.WriteLine("Все элементы массива А");                            //Вывод на экран массива А
            foreach (double i in arr)
                Console.Write($" {i} ");

            Console.WriteLine("\n\nМаксимальное значение - " + arr.Max());          //Максимальный элемент
            Console.WriteLine("Минимальное значение - " + arr.Min());               //Минимальный элемент
            Console.WriteLine("Сумма всех элементов - " + arr.Sum());               //Сумма всех элементов
            Console.WriteLine("Произведенеие всех элементов - " + Sum);             //Произведение элементов
            Console.WriteLine("Сумма четных элементов - " + even);                  //Произведение элементов

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВсе элементы массива B");
            Random rnd = new Random();                                              //Рандомайзер
            for (int i = 0; i < arr2.GetLength(0); i++)                             //Цикл обхода по строкам
            {
                for (int j = 0; j < arr2.GetLength(1); j++)                         //Цикл обхода по столбцам
                {
                    arr2[i, j] = rnd.NextDouble() * 100;                            //Генерируем случаное число с плавающей точкой
                    arr2[i, j] = Math.Round(arr2[i, j], 2);                         //Округляем до 2-х символов после запятой
                    Console.Write($" {arr2[i, j]}\t");                              //Вывод на экран мфссива В
                }
                Console.WriteLine();
            }

            double Mult = arr2[0, 0], Max = 0, Min = arr2[0, 0], Sum2 = arr2[0, 0];
            Sum = 0;
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (Max < arr2[i, j])                                           //Min
                        Max = arr2[i, j];
                    if (Min > arr2[i, j])                                           //Max
                        Min = arr2[i, j];
                    Sum += arr2[i, j];                                              //Сумма всех элементов
                    Mult *= arr2[i, j];                                             //Произведение всех элементов
                    if (j % 2 != 0)
                        Sum2 += arr2[i, j];                                         //Сумма нечетных столбцов
                }
            }
            Console.WriteLine("\nМаксимальное значение - " + Max);                  //Максимальный элемент
            Console.WriteLine("Минимальное значение - " + Min);                     //Минимальный элемент
            Console.WriteLine("Сумма всех элементов - " + Sum);                     //Сумма всех элементов
            Console.WriteLine("Произведенеие всех элементов - " + Mult);            //Произведение элементов
            Console.WriteLine("Сумма нечетных столбцов - " + Sum2);                 //Произведение элементов
        }
    }
}
