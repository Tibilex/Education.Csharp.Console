using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPAK
{

    internal class Program
    {
        public static void DictionaryData(Dictionary<string, string> dictENG, Dictionary<string, string> dictRUS)       // Метод хранения инициированых словарей
        {
            dictENG.Add("France", "Франция");
            dictENG.Add("Georgia", "Грузия");
            dictENG.Add("Ukraine", "Украина");
            dictENG.Add("Russia", "Россия");
            dictENG.Add("Germany", "Германия");
            dictENG.Add("Canada", "Канада");
            dictENG.Add("China", "Китай");
            dictENG.Add("Japan", "Япония");
            dictENG.Add("India", "Индия");
            dictENG.Add("Spain", "Испания");

            dictRUS.Add("Франция", "France");
            dictRUS.Add("Грузия", "Georgia");
            dictRUS.Add("Украина", "Ukraine");
            dictRUS.Add("Россия", "Russia");
            dictRUS.Add("Германия", "Germany");
            dictRUS.Add("Канада", "Canada");
            dictRUS.Add("Китай", "China");
            dictRUS.Add("Япония", "Japan");
            dictRUS.Add("Индия", "India");
            dictRUS.Add("Испания", "Spain");
        }
        public static void SearchWord(Dictionary<string, string> dictEng, Dictionary<string, string> dictRus)           // Метод поиска по словарю
        {
            int Keymenu = 0;                                                                                            // Ключ ввода меню
            string word;                                                                                                // Переменная ввода слова                                                                                      // Проверка на истиность слов
            while (Keymenu != 3)
            {
                Console.WriteLine(" Введите слово для поиска\n" +
                    " 1 - Английский ввод\n 2 - Русский ввод\n 3 - Выход", Console.ForegroundColor = ConsoleColor.Green);
                Keymenu = int.Parse(Console.ReadLine());
                switch (Keymenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите слово для поиска(Англ.)");
                        word = Console.ReadLine();
                        Checking(dictEng, word);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите слово для поиска(Рус.)");
                        word = Console.ReadLine();
                        Checking(dictRus, word);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        public static void PrintAll(Dictionary<string, string> dictENG, Dictionary<string, string> dictRUS)             // Метод вывода всехс ловарей в консоль
        {
            Console.Clear();
            Console.WriteLine(" Англо-Русский словарь", Console.ForegroundColor = ConsoleColor.White);
            foreach (object item in dictENG) { Console.WriteLine($" {item}"); }
            Console.WriteLine("\n Русско-Английский словарь");
            foreach (object item in dictRUS) { Console.WriteLine($" {item}"); }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ADDWord(Dictionary<string, string> dictENG, Dictionary<string, string> dictRUS)              // Метод добавления слова в словари
        {
            string word;                                                                                                // Переменная для ввода слова
            string translate;                                                                                           // Переменная для ввода слова перевода

            Console.WriteLine(" Введите слово(Англ.)", Console.ForegroundColor = ConsoleColor.Green);
            word = Console.ReadLine();
            Console.WriteLine(" Введите перевод слова(Рус.)");
            translate = Console.ReadLine();
            dictENG.Add(word, translate);                                                                               // Добавляем в словари переводы
            dictRUS.Add(translate, word);
            Console.WriteLine(" Слово добавлено во все словари");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DeleteWord(Dictionary<string, string> dictENG, Dictionary<string, string> dictRUS)           // Метод Удаления слова в словари
        {
            string word;                                                                                                // Переменная для ввода слова
            int keymenu;
            Console.Write(" Выберите словарь:\n 1 - Англо-Русский\n 2 - Русско-Английский\n",
                Console.ForegroundColor = ConsoleColor.Red);
            keymenu = int.Parse(Console.ReadLine());
            if (keymenu == 1)
            {
                Console.WriteLine(" Введите слово(Англ.)");
                word = Console.ReadLine();
                if (Checking(dictENG, word) == true)                                                                    // Проверка есть ли слово в колекции
                {
                    dictENG.Remove(word);                                                                               // Удадение слова
                    Console.WriteLine(" Успешно удалено!!!");
                }
            }
            if (keymenu == 2)
            {
                Console.WriteLine(" Введите слово(Рус.)");
                word = Console.ReadLine();
                if (Checking(dictRUS, word) == true)                                                                    // Проверка есть ли слово в колекции
                {
                    dictRUS.Remove(word);                                                                               // Удадение слова
                    Console.WriteLine(" Успешно удалено!!!");
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static bool Checking(Dictionary<string, string> dict, string word)                                       // Метод проверки на наличие слова в колекции
        {
            bool check = false;
            foreach (string key in dict.Keys)
            {
                if (word == key)
                {
                    Console.WriteLine($"Ваше слово - {key}, перевод - {dict[key]}\n");
                    return check = true;
                }
            }
            if (!check) { Console.WriteLine("Слово не найдено\n"); return check; }
            return false;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> dictEng = new Dictionary<string, string>();                                      // Обьявляен Словарь Англ.-Рус.
            Dictionary<string, string> dictRus = new Dictionary<string, string>();                                      // Обьявляен Словарь Рус.-Англ.
            int Keymenu = 0;
            DictionaryData(dictEng, dictRus);
            while (Keymenu != 5)
            {
                Console.WriteLine(" Англо-русский и Русско-Ангилйский словари\n" +
                    " 1 - Поиск слова в словаре\n 2 - Показать все словари\n" +
                    " 3 - Добавить слово в словарь\n 4 - Удалить слово словаря\n 5 - Выход",
                    Console.ForegroundColor = ConsoleColor.Yellow);
                Keymenu = int.Parse(Console.ReadLine());
                switch (Keymenu)
                {
                    case 1:
                        Console.Clear();
                        SearchWord(dictEng, dictRus);
                        break;
                    case 2:
                        PrintAll(dictEng, dictRus);
                        break;
                    case 3:
                        ADDWord(dictEng, dictRus);
                        break;
                    case 4:
                        DeleteWord(dictEng, dictRus);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}