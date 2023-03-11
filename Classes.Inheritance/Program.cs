using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPAK
{
    internal class Program
    {
        public abstract class Figure                                                                //Абстрактный класс "Фигура"
        {
            public virtual Colors Color { get; set; }                                               //Виртуальное поле "Цвет"
            public virtual void Display() { }                                                       //Виртуальный метод вывода на экран
            public virtual void CreateFigure(Colors Color) { }                                      //Виртуальный метод Создания фигуры
            public enum Colors : int                                                                //Перечислитель Цветов
            {
                Синий = ConsoleColor.Blue,
                Красный = ConsoleColor.Red,
                Желтый = ConsoleColor.Yellow,
                Зеленый = ConsoleColor.Green,
                Бирюзовый = ConsoleColor.Cyan,
                Фиолетовый = ConsoleColor.Magenta
            }
        }
        //===========================================================================================================================================//
        class Rectangle : Figure                                                                    //Класс "Прямоугольник" наследуется от "Фигура"
        {
            public override Colors Color { get; set; }                                              //Переопределенное поле "Цвет"
            public override void CreateFigure(Colors Color)                                         //Переопределенный метод Создания фигуры
            {                                                                                       //принимающий параметр цвета
                Console.ForegroundColor = (ConsoleColor)Color;
                int Size = 5;
                for (int i = 1; i <= Size; i++)
                {
                    for (int j = 1; j <= Size + Size; j++)
                    {
                        if ((j == 1 || j == Size + Size) || (i == 1 || i == Size))
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }                                                                                       //Переопределенный метод Вывода
            public override void Display() { Console.WriteLine($"Прямоугольник", Console.ForegroundColor = ConsoleColor.White); Console.ResetColor(); }
        }
        //===========================================================================================================================================//
        class Triangle : Figure                                                                     //Класс "Триугольник" наследуется от "Фигура"
        {
            public override Colors Color { get; set; }                                              //Переопределенное поле "Цвет"
            public override void CreateFigure(Colors Color)                                         //Переопределенный метод Создания фигуры
            {                                                                                       //принимающий параметр цвета
                Console.ForegroundColor = (ConsoleColor)Color;
                int Size = 5;
                int Px = Size;
                int Py = Size;
                for (int i = 1; i <= Size; i++)
                {
                    for (int j = 1; j < Size * 2; j++)
                    {
                        if (j == Px || j == Py || i == Size)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    Px--;
                    Py++;
                    Console.WriteLine();
                }
            }                                                                                       //Переопределенный метод Вывода
            public override void Display() { Console.WriteLine($"Треугольник", Console.ForegroundColor = ConsoleColor.White); Console.ResetColor(); }
        }
        //===========================================================================================================================================//
        class Trapezoid : Figure                                                                    //Класс "Трапеция" наследуется от "Фигура"
        {
            public override Colors Color { get; set; }                                              //Переопределенное поле "Цвет"
            public override void CreateFigure(Colors Color)                                         //Переопределенный метод Создания фигуры
            {                                                                                       //принимающий параметр цвета
                Console.ForegroundColor = (ConsoleColor)Color;
                int Size = 10;
                int size2;
                size2 = (Size + 2) / 3;
                for (int i = 0; i <= Size / 2; i++)
                {
                    for (int j = 0; j <= Size; j++)
                    {
                        if ((i == 0 && j >= size2 && j <= Size - size2) || j == size2 || j == Size - size2 || i == Size / 2 - 1) { Console.Write(" +"); }
                        else { Console.Write("  "); }
                    }
                    size2--;
                    Console.WriteLine();
                }
            }                                                                                       //Переопределенный метод Вывода
            public override void Display() { Console.WriteLine($"Трапеция", Console.ForegroundColor = ConsoleColor.White); Console.ResetColor(); }
        }
        //===========================================================================================================================================//
        class Rhombus : Figure                                                                      //Класс "Ромб" наследуется от "Фигура"
        {
            public override Colors Color { get; set; }                                              //Переопределенное поле "Цвет"
            public override void CreateFigure(Colors Color)                                         //Переопределенный метод Создания фигуры
            {                                                                                       //принимающий параметр цвета
                Console.ForegroundColor = (ConsoleColor)Color;
                int Size = 9;
                int mid = Size / 2 + 1;
                for (int i = 1; i <= Size; i++)
                {
                    for (int j = 1; j <= Size; j++)
                    {
                        if (j == mid || j == Size - mid + 1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    if (i <= Size / 2)
                        mid--;
                    else
                        mid++;
                    Console.WriteLine();
                }
            }                                                                                       //Переопределенный метод Вывода
            public override void Display() { Console.WriteLine($"Ромб", Console.ForegroundColor = ConsoleColor.White); Console.ResetColor(); }
        }
        //===========================================================================================================================================//
        class Polygon : Figure                                                                      //Класс "Многогранник" наследуется от "Фигура"
        {
            public override Colors Color { get; set; }                                              //Переопределенное поле "Цвет
            public override void CreateFigure(Colors Color)                                         //Переопределенный метод Создания фигуры
            {                                                                                       //принимающий параметр цвета
                Console.ForegroundColor = (ConsoleColor)Color;
                int size = 10;
                int size2;
                size2 = size / 3;
                for (int i = 0; i <= size; i++)
                {
                    for (int j = 0; j <= size; j++)
                    {
                        if (((i == 0 || i == size) && j > size2 && j < size - size2) || j == size2 || j == size - size2)
                            Console.Write(" +");
                        else
                            Console.Write("  ");
                    }
                    Console.WriteLine();
                    if (i < (size / 3)) { size2--; }
                    else if (i >= size - (size / 3)) { size2++; }
                }
            }                                                                                       //Переопределенный метод Вывода
            public override void Display() { Console.WriteLine($"Многоугольник", Console.ForegroundColor = ConsoleColor.White); Console.ResetColor(); }
        }
        //===========================================================================================================================================//
        public static void ColorsMenu()                                                             //Метод меню "Выбор цвета фигуры"
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" 1 - {Figure.Colors.Синий}\n 2 - {Figure.Colors.Красный}\n" +
                $" 3 - {Figure.Colors.Желтый}\n 4 - {Figure.Colors.Зеленый}\n" +
                $" 5 - {Figure.Colors.Бирюзовый}\n 6 - {Figure.Colors.Фиолетовый}");
            Console.ResetColor();
        }
        static public void SetColors(int choise, Figure obj)                                        //Метод окрашивания фигур
        {
            if (choise == 1) { obj.CreateFigure(Figure.Colors.Синий); }
            if (choise == 2) { obj.CreateFigure(Figure.Colors.Красный); }
            if (choise == 3) { obj.CreateFigure(Figure.Colors.Желтый); }
            if (choise == 4) { obj.CreateFigure(Figure.Colors.Зеленый); }
            if (choise == 5) { obj.CreateFigure(Figure.Colors.Бирюзовый); }
            if (choise == 6) { obj.CreateFigure(Figure.Colors.Фиолетовый); }
        }
        //===========================================================================================================================================//
        static void Main(string[] args)
        {
            int ColorKey = 0;                                                                       //Ключ ввода меню выбора цвета
            int MenuKey = 0;                                                                        //Ключ ввода меню
            int index = 0;                                                                          //Счетчик елементов массива обьектов класса "Фигура"
            int Counter = 10;                                                                       //Счетчик остатка фигур которые надо ввести
            Figure[] figureArray = new Figure[10];                                                  //Массив обьектов класса "Фигура"
            int[] ColorArray = new int[10];                                                         //Массив хранения параметров цвета фигур

            while (true)                                                                            //Бесконечный цикл
            {
                Console.WriteLine(" 1 - Создать Прямоугольник\n 2 - Создать Треугольник\n" +        //Меню выбора фигуры
                    " 3 - Создать Трапецию\n 4 - Создать Ромб\n 5 - Создать Многоугольник\n" +
                    " 6 - Показать все выбраные фигуры\n" + " 7 - Очистить маcсив и ввести фигуры заново\n 0 - Выход",
                    Console.ForegroundColor = ConsoleColor.White);
                Console.WriteLine($"Введите 10 фигур, осталось ввести фигур - {Counter}");
                Console.ResetColor();
                MenuKey = Convert.ToInt32(Console.ReadLine());
                switch (MenuKey)
                {
                    case 1:                                                                         //Кейс "Прямоугольник"
                        Figure Rect = new Rectangle();                                              //Создание нового обьекта класса
                        Console.WriteLine(" Выберите цвет фигуры:");
                        ColorsMenu();                                                               //Вызов метода выбора цвета
                        ColorKey = Convert.ToInt32(Console.ReadLine());                             //Ввод выбраного цвета
                        Console.Clear();
                        Rect.Display();                                                             //Вывод названия фигуры
                        SetColors(ColorKey, Rect);                                                  //Красим Фигуру
                        figureArray[index] = Rect;                                                  //Запись Обьекта в общий массив
                        ColorArray[index] = ColorKey;                                               //Запись номера цвета в массив
                        index++;                                                                    //Увеличение индекса массивов
                        Counter--;                                                                  //Уменьшение счеткика фигур для ввода
                        break;
                    case 2:                                                                         //Логика описана в кейсе "1"
                        Figure Tri = new Triangle();
                        Console.WriteLine(" Выберите цвет фигуры:");
                        ColorsMenu();
                        ColorKey = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Tri.Display();
                        SetColors(ColorKey, Tri);
                        figureArray[index] = Tri;
                        ColorArray[index] = ColorKey;
                        index++;
                        Counter--;
                        break;
                    case 3:                                                                         //Логика описана в кейсе "1"
                        Figure Trap = new Trapezoid();
                        Console.WriteLine(" Выберите цвет фигуры:");
                        ColorsMenu();
                        ColorKey = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Trap.Display();
                        SetColors(ColorKey, Trap);
                        figureArray[index] = Trap;
                        ColorArray[index] = ColorKey;
                        index++;
                        Counter--;
                        break;
                    case 4:                                                                         //Логика описана в кейсе "1"
                        Figure Romb = new Rhombus();
                        Console.WriteLine(" Выберите цвет фигуры:");
                        ColorsMenu();
                        ColorKey = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Romb.Display();
                        SetColors(ColorKey, Romb);
                        figureArray[index] = Romb;
                        ColorArray[index] = ColorKey;
                        index++;
                        Counter--;
                        break;
                    case 5:                                                                         //Логика описана в кейсе "1"
                        Figure Poly = new Polygon();
                        Console.WriteLine(" Выберите цвет фигуры:");
                        ColorsMenu();
                        ColorKey = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Poly.Display();
                        SetColors(ColorKey, Poly);
                        figureArray[index] = Poly;
                        ColorArray[index] = ColorKey;
                        index++;
                        Counter--;
                        break;
                    case 6:                                                                         //Кейс вывода всех фигур 
                        Console.Clear();
                        for (int i = 0; i < figureArray.Length; i++)                                //Цикл обхоа массива обьектов класса "Фигура"
                        {                                                                           //Выводим назване фигуры и сами фигуры с цветом
                            figureArray[i].Display();
                            SetColors(ColorArray[i], figureArray[i]);
                        }
                        Console.ReadLine();
                        break;
                    case 7:                                                                         //Кейс сброса данных для повторного ввода
                        Console.Clear(); Console.WriteLine("Массивы очищены счетчики сброшены", Console.ForegroundColor = ConsoleColor.White);
                        Array.Clear(figureArray, 0, figureArray.Length);                            //Обнуляем Массив обьктов класса
                        Array.Clear(ColorArray, 0, ColorArray.Length);                              //Обнуляем Массив цветов
                        Counter = 10;                                                               //Сброс счетчика введеных фигур
                        index = 0;                                                                  //Сброс индекса итератора массива
                        Console.ReadKey(); Console.Clear();
                        break;
                }
                if (MenuKey == 0)                                                                   //Условие выхода из бесконечного цикла
                    break;
            }
        }
    }
}
