using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStep2
{
    internal class Program
    {
        struct Article
        {
            private int id;
            private string Name;
            private int Price;
            public Article(int _id, string _name, int _price)
            {
                this.id = _id;
                this.Name = _name;
                this.Price = _price;
            }
            public void PrintAll()
            {
                Console.WriteLine($"Код товара - {id}\nНазвание товара - {Name}\nЦена товара - {Price} грн.");
            }
            static void Main()
            {
                Article article = new Article(13140571, "Пирожок", 10);
                Console.WriteLine("Описание товара");
                article.PrintAll();
            }
        }
    }
}