using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class EmployeeJobBuilder : EmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeJobBuilder At(string departmentName)
        {
            employee.DepartmentName = departmentName;
            return this;
        }

        public EmployeeJobBuilder AsA(string designation)
        {
            employee.Designation = designation;
            return this;
        }

        public EmployeeJobBuilder Earning(int annualIncome)
        {
            employee.AnnualIncome = annualIncome;
            return this;
        }
    }
}
