using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Class having implementation og 
    public class EmployeeBuilder // facade 
    {
        // the object we're going to build
        protected Employee employee = new Employee(); // this is a reference!

        // instantiating object of Employee Address class
        public EmployeeAddressBuilder Lives => new EmployeeAddressBuilder(employee);
        
        // instantiating object of Employee Job class
        public EmployeeJobBuilder Works => new EmployeeJobBuilder(employee);

        public static implicit operator Employee(EmployeeBuilder eb)
        {
            return eb.employee;
        }
    }
}
