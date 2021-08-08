using System;


namespace Factory
{

    class Program
    {
        static void Main(string[] args)
        {
            IDBConString dBConString = DBConFactory.GetDbConStringInstance(1); // Change value to get different connection string
            Console.WriteLine($"Connection string - {dBConString.ConString}");

            Console.ReadLine();
        }
    }
}
