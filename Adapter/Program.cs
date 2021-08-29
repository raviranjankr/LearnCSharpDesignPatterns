using System;
using System.Collections.Generic;

namespace Adapter
{

    // This is 'Adaptee' class, contains some useful behavior.
    class ThirdParty_Employees
    {
        public List<string> Get_EmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Mr R");
            EmployeeList.Add("Mr X");
            EmployeeList.Add("Miss Y");            
            return EmployeeList;
        }
    }

    //This is 'ITarget' interface, defines the domain-specific interface used by the client code.
    interface ITarget
    {
        List<string> Get_Employees();
    }
    // This is 'Adapter' class, makes the Adaptee's interface compatible with the ITarget interface.
    class EmployeeAdapter : ThirdParty_Employees, ITarget
    {
        public List<string> Get_Employees()
        {
            return Get_EmployeeList();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {                        
            ITarget adapter = new EmployeeAdapter();
            foreach (string employee in adapter.Get_Employees())
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}

