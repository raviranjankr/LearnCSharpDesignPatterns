using System;

namespace Singleton
{
   /* The sealed keyword prevents the further derivation of the class (so that its subclass cannot misuse it) */ 
    public sealed class Singleton
    {
        /* readonly ensures that the assignment process takes place during the static initialization */
        private static readonly Singleton
        instance = new Singleton();
        private int numberOfInstances = 0;
        /* 
         The constructor is private. So, you cannot instantiate the Singleton class inside Main(). 
         This will help you refer to the one instance that can exist in 
         the system. */
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", numberOfInstances);
        }
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Already Instance Attempted. Use it.");
            return instance;
            }
        }
    }


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
