using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // The Abstract Factory interface declares a set of methods that return
    // different abstract products. 
    public interface IBookFactory
    {
        IBook MakeBook(string author, string title, double price);
        IPublisher MakePublisher(string name);
    }
}
