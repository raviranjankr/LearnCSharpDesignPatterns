using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Employee
    {
        protected string Name;
        protected double Salary;
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public abstract void Add(Employee employee);

        public abstract void Remove(Employee employee);

        public abstract string GetEmployeeData();
    }  
}
