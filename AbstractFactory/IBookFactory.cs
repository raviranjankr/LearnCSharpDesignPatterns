using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IBookFactory
    {
        IBook MakeBook(string author, string title, double price);
        IPublisher MakePublisher(string name);
    }
}
