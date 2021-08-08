using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class EmployeeBuilder // facade 
    {
        // the object we're going to build
        protected Employee employee = new Employee(); // this is a reference!

        public EmployeeAddressBuilder Lives => new EmployeeAddressBuilder(employee);
        public EmployeeJobBuilder Works => new EmployeeJobBuilder(employee);

        public static implicit operator Employee(EmployeeBuilder eb)
        {
            return eb.employee;
        }
    }
}
