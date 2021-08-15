using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopWithLogin securedLaptop = new LaptopWithLogin(new LaptopWithNoLogin());
            securedLaptop.Open("invalid"); // Invalid Try.
            securedLaptop.Open("abc@123"); // Opening laptop
            securedLaptop.Close();

            Console.ReadKey();
        }
    }
}
