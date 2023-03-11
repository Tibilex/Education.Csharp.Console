using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        struct Client
        {
            private int id;
            private string Name;
            private int Buycouneter;
            private long Phone;
            private string Adress;
            private int Sum;
            public Client(int _id, string _name, int _buys, long _phone, string _adress, int _Sum)
            {
                this.id = _id;
                this.Name = _name;
                this.Buycouneter = _buys;
                this.Phone = _phone;
                this.Adress = _adress;
                this.Sum = _Sum;
            }
            public void PrintAll()
            {
                Console.WriteLine($"Код клиента - {id}\nФ.И.О. - {Name}\nАдрес - {Adress}");
                Console.WriteLine($"Номер телефона - {Phone}\nКоличество Покупок - {Buycouneter}\nСумма покупок - {Sum}");
            }
            public void AddBuys(int _sum) { Sum += _sum; Buycouneter++; }
        }
        static void Main()
        {
            Client client = new Client(13140571, "Бондаренко Д.А.", 0, 88005553535, "Ул.Дорожная 51", 0);
            Console.WriteLine("Данные клиента");

            for (int i = 0; i < 3; i++)
            {
                int buy = Int32.Parse(Console.ReadLine());
                client.AddBuys(buy);
            }
            client.PrintAll();
        }
    }
}

