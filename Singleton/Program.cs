using System;

namespace Singleton
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attempt to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Attempt to create instance s2.");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.ReadKey();
        }
    }
}
