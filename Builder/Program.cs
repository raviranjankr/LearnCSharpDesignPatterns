using System;

namespace Builder
{      
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeBuilder employeeBuilder = new EmployeeBuilder();            
            Employee employee = employeeBuilder.Lives.At("India").In("New Delhi").Works.At("NIC").AsA("Engineer").Earning(1000000);
            Console.WriteLine(employee);
            Console.ReadKey();
        }
    }
}
