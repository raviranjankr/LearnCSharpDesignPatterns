using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // All variants of the product must implement this interface. 
    // Interface will allow class to contain basic details of Book either it is cartoon or magazine
    public interface IBook
    {
        string Author { get; set; }
        string Title { get; set; }
        double Price { get; set; }
    }
}
