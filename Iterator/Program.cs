using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameCollections nameCollections = new NameCollections();

            for (IIterator iter = nameCollections.getIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine($"Name : {name}");
            }
            Console.ReadKey();
        }
    }
}
