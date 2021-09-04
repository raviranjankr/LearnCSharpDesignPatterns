using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Employee
    {
        public string Name;
        public double Salary;
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }     
    }  
}
