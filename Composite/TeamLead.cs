using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TeamLead 
    {
        List<Employee> lstEmployee = new List<Employee>();
        public void Add(Employee employee)
        {
            lstEmployee.Add(employee);
        }

        public void Remove(Employee employee)
        {
            lstEmployee.Remove(employee);
        }

        public string GetEmployeeData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Employee employee in lstEmployee)
            {
                stringBuilder.Append($"Name: {employee.Name} Salary: {employee.Salary.ToString("N2")}" + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
