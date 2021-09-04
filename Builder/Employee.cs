using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Class that contain field related to Employee only. 
    public class Employee
    {
        public string City, Country;
        public string DepartmentName, Designation;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(Country)}: {Country}, {nameof(City)}: {City}, {nameof(DepartmentName)}: {DepartmentName}, {nameof(Designation)}: {Designation}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
