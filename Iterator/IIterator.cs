using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    //Define the contract for our collection and iterator interfaces. Class going to inherit IIterator will responsible to hold next value out of list. 
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
