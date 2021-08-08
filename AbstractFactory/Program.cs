using System;

namespace AbstractFactory
{        
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
