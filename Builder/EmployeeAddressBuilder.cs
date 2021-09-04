using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Class that contain field of employee address only. 
    public class EmployeeAddressBuilder : EmployeeBuilder
    {
        // might not work with a value type!
        public EmployeeAddressBuilder(Employee employee)
        {
            this.employee = employee;
        }
        public EmployeeAddressBuilder At(string country)
        {
            employee.Country = country;
            return this;
        }
        public EmployeeAddressBuilder In(string city)
        {
            employee.City = city;
            return this;
        }
    }
}
