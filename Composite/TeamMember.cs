using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TeamMember : Employee
    {
        public TeamMember(string name, double salary) : base(name, salary) { }
        public override void Add(Employee employee)
        {
            //Operation not permitted since this is a leaf node.
        }

        public override void Remove(Employee employee)
        {
            //Operation not permitted since this is a leaf node.
        }

        public override string GetEmployeeData()
        {
            return "Name: " + Name + "\tSalary: " + Salary.ToString("N2");
        }
    }
}
