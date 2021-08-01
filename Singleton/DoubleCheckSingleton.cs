using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.DoubleCheckSingleton
{
    public sealed class Singleton
    {
        static Singleton instance = null;
        static readonly object lockobject = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockobject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

