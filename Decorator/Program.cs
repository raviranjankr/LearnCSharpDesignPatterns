using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGiftItem simpleGiftItem = new SimpleGiftItem();
            var purpleWrapper = new PurpleWrapper(simpleGiftItem);
            Console.WriteLine($"Item : {purpleWrapper.PackGiftItem()}, Price : {purpleWrapper.GetCost()}");
            var blueRibbon = new BlueRibbon(purpleWrapper);
            Console.WriteLine($"Item : {blueRibbon.PackGiftItem()}, Price : {blueRibbon.GetCost()}");
            Console.ReadLine();
        }
    }
}
