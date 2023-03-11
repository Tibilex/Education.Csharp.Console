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
            private ArticleType Type;
            public Article(int _id, string _name, int _price, ArticleType _type)
            {
                this.id = _id;
                this.Name = _name;
                this.Price = _price;
                this.Type = _type;
            }
            public void PrintAll()
            {
                Console.WriteLine($"Код товара - {id}\nНазвание товара - {Name}\nТип Товара - {Type}\nЦена товара - {Price} грн.");
            }
        }
        public enum ArticleType { Еда, Мебель, Одежда, Электроника, Медикаменты, Канцелярия, Компьютеры }
        static void Main()
        {
            Article article = new Article(13140571, "Пирожок", 10, ArticleType.Еда);
            Console.WriteLine("Описание товара");
            article.PrintAll();
        }
    }
}