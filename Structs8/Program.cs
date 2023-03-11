using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        class Student
        {
            private string FirstName;                                                           //Имя
            private string SecondName;                                                          //Фамилия
            private string Patronymic;                                                          //Отчество
            private string Group;                                                               //группа
            private int Age;                                                                    //Возраст
            int[][] Grade;                                                                      //Зубчатый массив оценок
            public Student(string Fname, string Sname, string patro, string group, int age, int[][] grade)
            {
                FirstName = Fname;
                SecondName = Sname;
                Patronymic = patro;
                Group = group;
                Age = age;
                this.Grade = grade;
            }
            public void PrintAll(int[][] grades)                                                //Показать данные студента
            {
                Console.WriteLine(" Данные студента");
                Console.WriteLine($" Имя - {FirstName}\n Фамилия - {SecondName}\n Отчество - {Patronymic}\n Группа - {Group}\n Возраст - {Age}");
                for (int i = 0; i < grades.Length; i++)
                {
                    if (i == 0)
                        Console.WriteLine($" Оценки факультета {faculties.Программирование}");
                    if (i == 1)
                        Console.WriteLine($" Оценки факультета {faculties.Администрирование}");
                    if (i == 2)
                        Console.WriteLine($" Оценки факультета {faculties.Дизайн}");
                    for (int j = 0; j < grades[i].Length; j++)
                    {
                        Console.Write(" " + grades[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($" Средний балл по {faculties.Программирование} = {AverageScore(0)}");
                Console.WriteLine($" Средний балл по {faculties.Администрирование} = {AverageScore(1)}");
                Console.WriteLine($" Средний балл по {faculties.Дизайн} = {AverageScore(2)}");
            }
            public int AverageScore(int facultyNum)                                             //Средний балл по предмету
            {
                int average = Convert.ToInt32(Grade[facultyNum].Average());
                return average;
            }
            public int GetGrade(int pos, int faculty)                                           //Получить оценку по предмету
            {
                return Grade[faculty][pos];
            }
            public void SetFirstName(string Fname) { FirstName = Fname; }                       //Установить Имя
            public void SetLastName(string Lname) { FirstName = Lname; }                        //Установить Фамилию
            public void SetPatronymic(string patronymic) { Patronymic = patronymic; }           //Установить Отчество
            public void SetGroup(string group) { Group = group; }                               //Установить Группу
            public void SetAge(int age) { Age = age; }                                          //Установить Возраст
            public void SetGrade(int pos, int faculty, int grade)                               //Установить оценку по предмету
            {
                Grade[faculty][pos] = grade;
            }
            public void ArrayInit(int[][] grades)                                                //Инициирование Изаполнение массива оценок
            {
                grades[0] = new int[5];
                grades[1] = new int[4];
                grades[2] = new int[6];
                Random random = new Random();
                for (int i = 0; i < Grade.Length; i++)
                {
                    for (int j = 0; j < Grade[i].Length; j++)
                    {
                        Grade[i][j] = random.Next(1, 12);
                    }
                }
            }
        }
        enum faculties { Программирование, Администрирование, Дизайн }                         //Перечислитель факультетов
        enum Menu { ФИО, Группа, Возраст, Оценки, Инфо, Добавить, Показать }
        static void Main()
        {
            int[][] Grades = new int[3][];

            Student student = new Student("Евгений", "Богомолов", "Владимирович", "ВБУ011", 31, Grades);
            student.ArrayInit(Grades);
            int Key = 0;
            while (Key != 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Класс Студент\n 1 - Задать ФИО\n 2 - Задать группу\n 3 - Задать возраст студента\n" +
                    " 4 - Показать или задать оценку\n 5 - Показать Всю информацию");
                Key = Convert.ToInt32(Console.ReadLine()) - 1;

                switch ((Menu)Key)
                {
                    case Menu.ФИО:
                        Console.Clear();
                        Console.WriteLine(" Меню < 1 >\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" Введите Имя >> ");
                        student.SetFirstName(Console.ReadLine());
                        Console.Write(" Введите Фамилию >> ");
                        student.SetLastName(Console.ReadLine());
                        Console.Write(" Введите Отчество >> ");
                        student.SetPatronymic(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                    case Menu.Группа:
                        Console.Clear();
                        Console.WriteLine(" Меню < 2 >\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" Введите название группы >> ");
                        student.SetGroup(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                    case Menu.Возраст:
                        Console.Clear();

                        Console.WriteLine(" Меню < 3 >\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" Введите возраст студента >> ");
                        student.SetAge(Convert.ToInt32(Console.ReadLine()));
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                    case Menu.Оценки:
                        Console.Clear();
                        Console.WriteLine(" Меню < 4 >\n\n 1 - Вставить конкретную оценку\n 2 - Показать конкретную оценку");
                        int Key2 = Convert.ToInt32(Console.ReadLine()) + 4;
                        switch ((Menu)Key2)
                        {
                            case Menu.Добавить:
                                Console.Clear();
                                Console.WriteLine($" Меню < 4.1 >\n\n Текущие оценки | 1 = {faculties.Программирование} |");
                                foreach (int i in Grades[0])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Текущие оценки | 2 = {faculties.Администрирование} |");
                                foreach (int i in Grades[1])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Текущие оценки | 3 = {faculties.Дизайн} |");
                                foreach (int i in Grades[2])
                                    Console.Write(" " + i + " ");
                                Console.Write("\n В какую категорию и позицию вставляем?(индекс учитываеться)\n Категория? >> ");
                                int Facult = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.Write(" Позиция? >> ");
                                int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.Write(" Введите оценку >> ");
                                int grade = Convert.ToInt32(Console.ReadLine());
                                student.SetGrade(pos, Facult, grade);
                                Console.Clear();
                                Console.WriteLine($" Меню < 4.1 >\n\n Измененная запись\n Текущие оценки | 1 = {faculties.Программирование} |");
                                foreach (int i in Grades[0])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Текущие оценки | 2 = {faculties.Администрирование} |");
                                foreach (int i in Grades[1])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Текущие оценки | 3 = {faculties.Дизайн} |");
                                foreach (int i in Grades[2])
                                    Console.Write(" " + i + " ");
                                Console.ReadKey();
                                break;
                            case Menu.Показать:
                                Console.Clear();
                                Console.WriteLine(" Меню < 4.2 >\n");
                                Console.WriteLine(" Массив показан для удобства\n", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($" Показать оценку в категории | 1 = {faculties.Программирование} | ");
                                foreach (int i in Grades[0])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Показать оценку в категории | 2 = {faculties.Администрирование} |");
                                foreach (int i in Grades[1])
                                    Console.Write(" " + i + " ");
                                Console.WriteLine($"\n Показать оценку в категории | 3 = {faculties.Дизайн} |");
                                foreach (int i in Grades[2])
                                    Console.Write(" " + i + " ");
                                Console.Write("\n В какой категории и позиции показать оценку?(индекс учитываеться)\n Категория? >> ");
                                Facult = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.Write(" Позиция? >> ");
                                pos = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.Write("Ваша оценка - " + student.GetGrade(pos, Facult));
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        Console.Clear();
                        break;
                    case Menu.Инфо:
                        Console.Clear();
                        Console.WriteLine(" Меню < 5 >\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        student.PrintAll(Grades);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        break;
                }
            }


        }
    }
}

