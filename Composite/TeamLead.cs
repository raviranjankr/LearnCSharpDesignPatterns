using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TeamLead : Employee
    {
        List<Employee> lstEmployee = new List<Employee>();
        public TeamLead(string name, double salary) : base(name, salary) { }
        public override void Add(Employee employee)
        {
            lstEmployee.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            lstEmployee.Remove(employee);
        }

        public override string GetEmployeeData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Employee employee in lstEmployee)
            {
                stringBuilder.Append(employee.GetEmployeeData() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
