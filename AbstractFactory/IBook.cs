using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // All variants of the product must implement this interface.
    public interface IBook
    {
        string Author { get; set; }
        string Title { get; set; }
        double Price { get; set; }
    }
}
