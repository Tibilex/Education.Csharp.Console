using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPAK
{

    internal class Program
    {
        public static void PrintArray(int[] Arr)                                                        //Метод вывода массивов
        {
            foreach (int index in Arr)
            {
                Console.Write($" {index} ");
            }
        }
        public static void Solve(int[] MainArray, int[] AuxArray, int[] AuxArray2, int trys)            //Метод решения задачи
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random random = new Random();                                                               //Обьект класса рандом
            for (int i = 0; i < MainArray.Length; i++)
            {
                MainArray[i] = random.Next(1, 20);                                                      //Генерируем число от 1 до 20
            }
            if (MainArray.Sum() % 2 == 1)                                                               //Если сумма элем. массива не четная
            {
                trys++;                                                                                 //Счетчик не удачных генераций
                Solve(MainArray, AuxArray, AuxArray2, trys);                                            //Рекурентно вызываем метод заново для генерации нового массива
            }
            else
            {                                                                                           //Если сумма элем. массива четная
                Array.Sort(MainArray);                                                                  //Сортируем заполненый массив
                Console.WriteLine($" Основной сортированый массив, Количество Рерандомизаций = {trys}");
                PrintArray(MainArray); Console.WriteLine($"Сумма всех элементов {MainArray.Sum()}");
                for (int i = 0, j = 0; i < MainArray.Length; j++)                                       //Заполняем вспомогательные массивы через один
                {
                    AuxArray[j] = MainArray[i];
                    i++;
                    AuxArray2[j] = MainArray[i];
                    i++;
                }
                Console.Write("\n Вспомогательные массивы\n Массив 1 =");
                PrintArray(AuxArray); Console.WriteLine($"Сумма всех элементов {AuxArray.Sum()}");
                Console.Write("\n Массив 2 =");
                PrintArray(AuxArray2); Console.WriteLine($"Сумма всех элементов {AuxArray2.Sum()}");

                int ArraySum = AuxArray.Sum();                                                          //Переменная суммы элем. доп. массива 1
                int ArraySum2 = AuxArray2.Sum();                                                        //Переменная суммы элем. доп. массива 2
                int Diff = ArraySum2 - ArraySum;                                                        //Переменная разницы сумм массивов
                for (int i = 0; i < AuxArray.Length; i++)
                {
                    for (int j = 0; j < AuxArray2.Length; j++)
                    {
                        if (AuxArray2[j] - AuxArray[i] == Diff / 2)                                     //Если текущий элемент масивов равен разнице / 2
                        {
                            int temp = AuxArray2[j];                                                    //Текущий элемент массива 2 запишем в временную переменную
                            AuxArray2[j] = AuxArray[i];                                                 //Меняем местами элементы 
                            AuxArray[i] = temp;                                                         //В текущий элемент массива 1 запишем значение из переменной
                            i = AuxArray.Length + 1;                                                    //прерывание цикла когда решение найдено
                            j = AuxArray2.Length + 1;
                        }
                    }
                }
                Console.Write("\n Результат работы программы\n Массив 1 =");
                PrintArray(AuxArray); Console.WriteLine($"Сумма всех элементов {AuxArray.Sum()}");
                Console.Write("\n Массив 2 =");
                PrintArray(AuxArray2); Console.WriteLine($"Сумма всех элементов {AuxArray2.Sum()}");
                if (AuxArray.Sum() == AuxArray2.Sum())
                    Console.WriteLine("\n Массивы равны", Console.ForegroundColor = ConsoleColor.Green);
                else
                    Console.WriteLine(" Массивы не равны", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
        static void Main(string[] args)
        {
            int trys = 0;                                                                               //Счетчик попыток генерации основного массива
            const int Size = 16;
            int[] MainArray = new int[Size];                                                            //Основной массив на 16 элементов
            int[] AuxiliaryArray = new int[Size / 2];                                                   //Вспомогательный массив на 8 элементов
            int[] AuxiliaryArray2 = new int[Size / 2];                                                  //Вспомогательный массив на 8 элементов
            Solve(MainArray, AuxiliaryArray, AuxiliaryArray2, trys);                                    //Вызов метода решения задачи с параметрами
        }
    }
}