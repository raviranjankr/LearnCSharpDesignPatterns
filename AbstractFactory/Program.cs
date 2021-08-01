using System;

namespace AbstractFactory
{
    public interface IBook
    {
        string Author { get; set; }
        string Title { get; set; }
        double Price { get; set; }
    }

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
    public interface IPublisher
    {
        string Name { get; set; }
    }
    public class Blog : IPublisher
    {
        public string Name { get; set; }
        public Blog(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}.");
        }
    }
    public class ScientificJournal : IPublisher
    {
        public string Name { get; set; }
        public ScientificJournal(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}.");
        }
    }

    public interface IBookFactory
    {
        IBook MakeBook(string author, string title, double price);
        IPublisher MakePublisher(string name);
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

    class Program
    {
        static void Main(string[] args)
        {
            new CartoonFactory(author: "Author A",
                   title: "Book A",
                   publisher: "publisher A",
                   price: 100
                   );

            new MagazineFactory(author: "Author B",
                   title: "Book B",
                   publisher: "publisher B",
                   price: 200);
            Console.Read();
        }
    }
}
