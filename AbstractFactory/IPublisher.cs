using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IPublisher
    {
        string Name { get; set; }
    }
    public class Blog : IPublisher
    {
        public string Name { get; set; }
        public Blog(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}.");
        }
    }
    public class ScientificJournal : IPublisher
    {
        public string Name { get; set; }
        public ScientificJournal(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}.");
        }
    }
}
