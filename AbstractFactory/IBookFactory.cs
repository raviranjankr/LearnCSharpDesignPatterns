using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Abstract Factory Interface : The Abstract Factory interface declares a set of methods that return different abstract products. 
    // Products of one family are usually able to collaborate among themselves.
    // A family of products may have several variants, but the products of one variant are incompatible
    // with products of another.
    public interface IBookFactory
    {
        IBook MakeBook(string author, string title, double price);
        IPublisher MakePublisher(string name);
    }
}
