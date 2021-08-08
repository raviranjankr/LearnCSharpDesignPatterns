using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Cartoon : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Cartoon(string author, string title, double price)
        {
            Author = author;
            Title = title;
            Price = price;
            Console.WriteLine($"Made an IBook of type: {this.ToString()}.");
        }
    }

    public class CartoonFactory : IBookFactory
    {
        public CartoonFactory() { }

        public CartoonFactory(string author, string title, string publisher, double price)
        {
            MakeBook(author: author, title: title, price: price);
            MakePublisher(name: publisher);
            Console.WriteLine($"Made an IBookFactory of type: {this.ToString()}.");
        }

        public IBook MakeBook(string author, string title, double price)
        {
            return new Cartoon(author: author, title: title, price: price);
        }

        public IPublisher MakePublisher(string name)
        {
            return new Blog(name: name);
        }
    }
}
