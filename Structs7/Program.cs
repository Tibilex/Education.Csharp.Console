using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        struct Request
        {
            public int id;
            public string Name;
            public string Date;
            public string[] Products;
            public int Sum;
            public PayType PayType;
            public Request(int _id, string _name, string _date, string[] _prod, int _sum, PayType _paytype)
            {
                this.id = _id;
                this.Name = _name;
                this.Date = _date;
                this.Products = _prod;
                Sum = _sum;
                PayType = _paytype;
            }
            public void printAll()
            {
                Console.WriteLine($"Код заказа - {id}\nКлиент - {Name}\nДата заказа - {Date}\nСумма заказа - {Sum}\nТип оплаты - {PayType}");
            }
            public int SumRequest(int _sum) { return Sum += _sum; }
            public void ProductsList()
            {
                for (int i = 0; i < Products.Length; i++)
                {

                    Console.WriteLine($"Товар номер {i + 1} - {Products[i]}");
                }
            }
        }
        enum PayType { Наличный, Безналичный, Карта, Наложенный }
        static void Main()
        {
            Request request = new Request();
            request.Products = new string[3];

            Console.Write("Введите Код заказа - ");
            request.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Имя клиента - ");
            request.Name = Console.ReadLine();
            Console.Write("Введите дату заказа - ");
            request.Date = Console.ReadLine();
            for (int i = 0; i < request.Products.Length; i++)
            {
                Console.WriteLine("Введите название товара");
                request.Products[i] = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                int sum = Convert.ToInt32(Console.ReadLine());
                request.SumRequest(sum);
            }
            Console.WriteLine("Введите Тип оплаты\n1 - Наличный\n2 - Безналичный\n3 - Карта\n4 - Наложенный");
            int number = Int32.Parse(Console.ReadLine());
            PayType key = (PayType)Enum.GetValues(typeof(PayType)).GetValue(number - 1);
            switch (key)
            {
                case PayType.Наличный:
                    request.PayType = PayType.Наличный;
                    break;
                case PayType.Безналичный:
                    request.PayType = PayType.Безналичный;
                    break;
                case PayType.Карта:
                    request.PayType = PayType.Карта;
                    break;
                case PayType.Наложенный:
                    request.PayType = PayType.Наложенный;
                    break;
            }
            Console.Clear();
            request.printAll();
            request.ProductsList();
        }
    }
}

