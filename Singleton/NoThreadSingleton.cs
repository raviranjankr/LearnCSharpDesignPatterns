using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NoThreadSingleton
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
