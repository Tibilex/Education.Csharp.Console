using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPAK
{
    public class Money                                                                      // Класс Money
    {
        public Money(int uAH, int kOP)                                                      // Конструктор класса Money
        {
            UAH = uAH;
            KOP = kOP;
        }
        int UAH { get; set; }                                                               // Поле гривны
        int KOP { get; set; }                                                               // Поле копейки
        public static Money operator +(Money mon, Money mon2)                               // Прегрузка оператора '+'              
        {
            if (mon.KOP + mon2.KOP >= 100)                                                  // добавляем 1 к гривне если сумма копеек больше 100
            {
                mon.UAH++;                                                                  // Инкремент на гривны перегружен в классе
                mon.KOP -= 100;
                return new Money(mon.UAH + mon2.UAH, mon.KOP + mon2.KOP);                   // Возвращаем новый обьект с суммой чисел
            }
            else
                return new Money(mon.UAH + mon2.UAH, mon.KOP + mon2.KOP);
        }
        public static Money operator -(Money mon, Money mon2)                               // Прегрузка оператора '-'
        {
            try
            {                                                                               // Блок try catch для отлова отрицаетельных чисел
                if (mon.UAH - mon2.UAH < 0 && mon.KOP - mon2.KOP < 0)                       // Условие вычитания копеек, если сумма отрицаетльная сработает исключение
                {
                    mon.UAH--;                                                              // Декемент перегружен в классе
                    mon.KOP += 100;
                    throw new ArgumentOutOfRangeException();                                // Исключение проверяющее диапазон чисел
                }
                if (mon.KOP - mon2.KOP < 0)                                                 // Условие вычитания копеек при условии что конечная сумма положительная
                {
                    mon.UAH--;
                    mon.KOP += 100;
                    return new Money(mon.UAH - mon2.UAH, mon.KOP - mon2.KOP);               // Возвращаем новый обьект с суммой чисел
                }
                else
                    return new Money(mon.UAH - mon2.UAH, mon.KOP - mon2.KOP);
            }
            catch (Exception) when (mon.UAH - mon2.UAH < 0 || mon2.UAH - mon.UAH < 0)       // Условие срабатывания исключения
            {
                Console.WriteLine($" Банкрот", Console.ForegroundColor = ConsoleColor.Red); // Сообщение сработаного исключения
                return new Money(mon.UAH - mon2.UAH, mon.KOP - mon2.KOP);
            }
        }
        public static Money operator *(Money mon, Money mon2)                               // Прегрузка оператора '*'
        {
            mon.UAH *= mon2.UAH;
            mon.KOP *= mon2.KOP;
            for (int i = 0; mon.KOP > 99; i++)                                              // Проверка на сумму копеек если боьше 99 то...
            {
                mon.UAH++;                                                                  // Увеличиваем гривну 
                mon.KOP -= 100;                                                             // Отнимаем 100 копеек от обьщей суммы
            }
            return new Money(mon.UAH, mon.KOP);                                             // Возвращаем новый обьект с суммой чисел
        }
        public static Money operator /(Money mon, Money mon2)                               // Прегрузка оператора '/'
        {
            try
            {                                                                               // Блок try catch для отлова деления на 0
                if (mon2.UAH == 0 || mon2.KOP == 0 || mon.UAH == 0 || mon.KOP == 0)         // Как только видим 0           
                    throw new DivideByZeroException();                                          // Срабатывает исключение
                else
                    return new Money(mon.UAH / mon2.UAH, mon.KOP / mon2.KOP);               // Возвращаем новый обьект с суммой чисел
            }
            catch (Exception)
            {                                                                               // Сообщение сработаного исключения
                Console.WriteLine($" Нельзя делить на 0", Console.ForegroundColor = ConsoleColor.Red);
                return new Money(mon.UAH / mon2.UAH, mon.KOP / mon2.KOP);
            }
        }
        public static Money operator ++(Money mon) { mon.KOP++; return mon; }               // Прегрузка оператора '++'
        public static Money operator --(Money mon) { mon.KOP--; return mon; }               // Прегрузка оператора '--'
        public static bool operator ==(Money mon, Money mon2) => mon.Equals(mon2);          // Прегрузка оператора '=='
        public static bool operator !=(Money mon, Money mon2) => !mon.Equals(mon2);         // Прегрузка оператора '!='
        public override bool Equals(object obj) => ToString() == obj.ToString();            // Переопределение метода Equals
        public override int GetHashCode() => ToString().GetHashCode();                      // Переопределение метода GetHashCode
        public static bool operator <(Money mon, Money mon2) => Equals(mon, mon2);          // Прегрузка оператора '<'
        public static bool operator >(Money mon, Money mon2) => Equals(mon, mon2);          // Прегрузка оператора '>'
        public override string ToString() => $" UAH = {UAH},{KOP}";                         // Переопределение метода ToString
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int MenuKey = 0;
            Console.WriteLine("\t  КЛАСС ДЕНЬГИ\n Введите сумму 'Гривны и копейки' для объекта А");
            int UAH = int.Parse(Console.ReadLine());
            int KOP = int.Parse(Console.ReadLine());
            Money A = new(UAH, KOP);
            Console.WriteLine(" Введите сумму 'Гривны и копейки' для объекта В");
            UAH = int.Parse(Console.ReadLine());
            KOP = int.Parse(Console.ReadLine());
            Money B = new(UAH, KOP);
            Money C;
            while (MenuKey != 8)
            {
                Console.WriteLine(" Выберите действие\n 1 => '+'\n 2 => '-'\n 3 => '*'\n 4 => '/'\n" +
                     " 5 => '>'\n 6 => '<'\n 7 => '=='\n 8 => Выход");
                MenuKey = Convert.ToInt32(Console.ReadLine());
                switch (MenuKey)
                {
                    case 1:
                        Console.Clear();
                        C = A + B; Console.WriteLine($"{C}\n");
                        break;
                    case 2:
                        Console.Clear();
                        C = A - B; Console.WriteLine($"{C}\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 3:
                        Console.Clear();
                        C = A * B; Console.WriteLine($"{C}\n");
                        break;
                    case 4:
                        Console.Clear();
                        C = A / B; Console.WriteLine($"{C}\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 5:
                        Console.Clear();
                        bool check = A < B; Console.WriteLine($"{check}\n");
                        break;
                    case 6:
                        Console.Clear();
                        check = A > B; Console.WriteLine($"{check}\n");
                        break;
                    case 7:
                        Console.Clear();
                        check = A == B; Console.WriteLine($"{check}\n");
                        break;
                }
            }
        }
    }
}