using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        struct RequestItem
        {
            private string Product;
            private int Product_count;
            public RequestItem(string _prod, int count)
            {
                this.Product = _prod;
                this.Product_count = count;
            }
            public void PrintAll()
            {
                Console.WriteLine($"Название товара - {Product}\nКоличество товара - {Product_count}");
            }
        }
        static void Main()
        {
            RequestItem product = new RequestItem("Пирожок", 10);
            RequestItem product2 = new RequestItem("Беляш", 20);
            RequestItem product3 = new RequestItem("Чебурек", 15);
            Console.WriteLine("Данные по товарам");

            product.PrintAll();
            product2.PrintAll();
            product3.PrintAll();
        }
    }
}

