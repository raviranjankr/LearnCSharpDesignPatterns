using System;

namespace Prototype
{
    public class Employee
    {
        public int Experience;
        public DateTime DOB;
        public string Name;
        public EmpID EmpID;

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee clone = (Employee)this.MemberwiseClone();
            clone.EmpID = new EmpID(EmpID.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }
    public class EmpID
    {
        public int IdNumber;

        public EmpID(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        public static void DisplayValues(Employee p)
        {
            Console.WriteLine("Name: {0:s}, Experience: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Experience, p.DOB);
            Console.WriteLine("ID: {0:d}", p.EmpID.IdNumber);
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "ABC XYZ";
            employee.Experience = 5;
            employee.DOB = Convert.ToDateTime("01-01-2001");
            employee.EmpID = new EmpID(1);

            Employee employee_s= employee.ShallowCopy();
            Employee employee_d = employee.DeepCopy();

            // Display values of all three object
            Console.WriteLine("Original values of");
            Console.WriteLine("employee instance values: ");
            DisplayValues(employee);
            Console.WriteLine("employee_s instance values:");
            DisplayValues(employee_s);
            Console.WriteLine("employee_d instance values:");
            DisplayValues(employee_d);


            // Now Change the value of employee properties and display the values again,
            // p2 and p3.
            employee.Name = "ABC XYZ 1";
            employee.Experience = 10;
            employee.DOB = Convert.ToDateTime("01-01-2002");
            employee.EmpID.IdNumber =  2;  // new EmpID(2);
            Console.WriteLine("\nValues of all three instances again:");
            Console.WriteLine("employee instance values: ");
            DisplayValues(employee);
            Console.WriteLine("employee_s instance values :");
            DisplayValues(employee_s); // reference values(EmpID) will get changed
            Console.WriteLine("employee_d instance values :");
            DisplayValues(employee_d); // No Changes


            Console.ReadLine();
        }
    }
}
