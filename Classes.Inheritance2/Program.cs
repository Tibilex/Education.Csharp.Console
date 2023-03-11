using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep3
{
    internal class Program
    {
        public abstract class Distibutor
        {
            protected string Name { get; set; }
            protected int Key_counter = 0;
            public virtual void Add_Product() { }
            public virtual void Print() { }
            protected ADDED ADD = new ADDED();
            protected IMPLEMENT IMPL = new IMPLEMENT();
            protected WRITTENOFF W_OFF = new WRITTENOFF();
            protected TRANSFERRED TRANS = new TRANSFERRED();
            public class ADDED
            {
                protected int add = 0;
                public int Added()
                {
                    add++;
                    return add;
                }
                public void Print()
                {
                    Console.WriteLine($"Количество поступившего товара = {add}");
                }
            }
            public class IMPLEMENT
            {
                public int impl = 0;
                public int implemented()
                {
                    impl++;
                    return impl;
                }
                public void Print()
                {
                    Console.WriteLine($"Количество реализованого товара = {impl}");
                }
            }
            public class WRITTENOFF
            {
                public int WRT = 0;
                public int written_off()
                {
                    WRT++;
                    return WRT;
                }
                public void Print()
                {
                    Console.WriteLine($"Количество списаного товара = {WRT}");
                }
            }
            public class TRANSFERRED
            {
                public int TRD = 0;
                public int transferred()
                {
                    TRD++;
                    return TRD;
                }
                public void Print()
                {
                    Console.WriteLine($"Количество переданого товара = {TRD}");
                }
            }
        }
        class Chemical : Distibutor
        {
            Dictionary<int, string> ChemProduct = new Dictionary<int, string>
            {
                [1] = "Шампунь",
                [2] = "Зубная Паста",
                [3] = "Стиральный Порошок",
                [4] = "Освежитель Воздуха",
                [5] = "Моющее Средство"
            };
            public override void Add_Product()
            {
                Key_counter = ChemProduct.Keys.Last() + 1;
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                ChemProduct.Add(Key_counter, Name);
                Console.WriteLine();
                ADD.Added();
            }
            public override void Print()
            {
                Console.WriteLine("Все Товары в категории \"Бытовая Химия\"");
                foreach (KeyValuePair<int, string> kvp in ChemProduct)
                    Console.WriteLine(kvp);
                Console.WriteLine();
            }
        }
        class Food : Distibutor
        {
            Dictionary<int, string> FoodProduct = new Dictionary<int, string>
            {
                [1] = "Яблоко",
                [2] = "Картофель",
                [3] = "Томаты",
                [4] = "Клубника",
                [5] = "Хлеб"
            };
            public override void Add_Product()
            {
                Key_counter = FoodProduct.Keys.Last() + 1;
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                FoodProduct.Add(Key_counter, Name);
                Console.WriteLine();
                ADD.Added();
            }
            public override void Print()
            {
                Console.WriteLine("Все Товары в категории \"Продукты Питания\"");
                foreach (KeyValuePair<int, string> kvp in FoodProduct)
                    Console.WriteLine(kvp);
                Console.WriteLine();
            }
        }
        class Electronic : Distibutor
        {
            Dictionary<int, string> ElectProduct = new Dictionary<int, string>
            {
                [1] = "Смартфон",
                [2] = "Телефизор",
                [3] = "Утюг",
                [4] = "Блендер",
                [5] = "Игровая Консоль"
            };
            public override void Add_Product()
            {
                Key_counter = ElectProduct.Keys.Last() + 1;
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                ElectProduct.Add(Key_counter, Name);
                Console.WriteLine();
                ADD.Added();
            }
            public override void Print()
            {
                Console.WriteLine("Все Товары в категории \"Електроника\"");
                foreach (KeyValuePair<int, string> kvp in ElectProduct)
                    Console.WriteLine(kvp);
                Console.WriteLine();
            }
        }
        class Cloth : Distibutor
        {
            Dictionary<int, string> ClothProduct = new Dictionary<int, string>
            {
                [1] = "Футболка",
                [2] = "Штаны",
                [3] = "Куртка",
                [4] = "Свитер",
                [5] = "Сапоги"
            };
            public override void Add_Product()
            {
                Key_counter = ClothProduct.Keys.Last() + 1;
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                ClothProduct.Add(Key_counter, Name);
                Console.WriteLine();
                ADD.Added();
            }
            public override void Print()
            {
                Console.WriteLine("Все Товары в категории \"Одежда\"");
                foreach (KeyValuePair<int, string> kvp in ClothProduct)
                    Console.WriteLine(kvp);
                Console.WriteLine();
            }
        }
        class Sport : Distibutor
        {
            Dictionary<int, string> SportProduct = new Dictionary<int, string>
            {
                [1] = "Мяч",
                [2] = "Коврик для Йоги",
                [3] = "Гантеля",
                [4] = "Скакалка",
                [5] = "Фрисби"
            };
            public override void Add_Product()
            {
                Key_counter = SportProduct.Keys.Last() + 1;
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                SportProduct.Add(Key_counter, Name);
                Console.WriteLine();
                ADD.Added();
            }
            public override void Print()
            {
                Console.WriteLine("Все Товары в категории \"Спорт товары\"");
                foreach (KeyValuePair<int, string> kvp in SportProduct)
                    Console.WriteLine(kvp);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Distibutor A = new Chemical();
            Distibutor B = new Food();
            Distibutor C = new Electronic();
            Distibutor D = new Cloth();
            Distibutor E = new Sport();
            Distibutor.ADDED AA = new Distibutor.ADDED();
            Distibutor.IMPLEMENT BB = new Distibutor.IMPLEMENT();
            Distibutor.WRITTENOFF CC = new Distibutor.WRITTENOFF();
            Distibutor.TRANSFERRED DD = new Distibutor.TRANSFERRED();

            A.Print();
            B.Print();
            C.Print();
            D.Print();
            E.Print();

            AA.Print();
            BB.Print();
            CC.Print();
            DD.Print();
        }
    }
}
