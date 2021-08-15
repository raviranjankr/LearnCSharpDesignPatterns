using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
   public interface IIterator
    {
        public bool hasNext();
        public Object next();
    }
    public interface IContainer
    {
        public IIterator getIterator();
    }

}
