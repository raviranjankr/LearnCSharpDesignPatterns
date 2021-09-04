using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Magazine : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Magazine(string author, string title, double price)
        {
            Author = author;
            Title = title;
            Price = price;
            Console.WriteLine($"Made an IBook of type: {this.ToString()}.");
        }
    }

    // This class belong to a single variant which is Magazine. The factory guarantees that resulting products are compatible.
    // Our factory classes will implement this interface(Abstract Factory Interface)
    public class MagazineFactory : IBookFactory
    {
        public MagazineFactory() { }

        public MagazineFactory(string author, string title, string publisher, double price)
        {
            MakeBook(author: author, title: title, price: price);
            MakePublisher(name: publisher);
            Console.WriteLine($"Made an IBookFactory of type: {this.ToString()}.");
        }

        public IBook MakeBook(string author, string title, double price)
        {
            return new Magazine(author: author, title: title, price: price);
        }

        public IPublisher MakePublisher(string name)
        {
            return new ScientificJournal(name: name);
        }
    }
}
