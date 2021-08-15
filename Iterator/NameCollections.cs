using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class NameCollections : IContainer
    {        
        public IIterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            public string[] names = { "Ravi", "Ranjan", "Kumar" };
            int index;

            public bool hasNext()
            {                
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }
            public Object next()
            {

                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
