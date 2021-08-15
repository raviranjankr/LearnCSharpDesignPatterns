using System;
using System.Collections.Generic;

namespace Flyweight
{
 

    class Program
    {
        static void Main(string[] args)
        {
            ChaiMaker chaiMaker = new ChaiMaker();
            ChaiStall chaiShop = new ChaiStall(chaiMaker);

            chaiShop.TakeOrder("less sugar tea", 1);
            chaiShop.TakeOrder("more sugar tea", 2);
            chaiShop.TakeOrder("ginger tea", 3);

            chaiShop.Serve();

            Console.ReadKey();

        }
    }
}
